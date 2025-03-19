using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionBDEmployee
{
    internal class DALJob
    {
        DBConnection conn;
        public DALJob() 
        { 
           conn = new DBConnection();
        }

        public List<Job> GetJobs()
        {
            List<Job> jobs = new List<Job>();
            try
            {
                conn.AbrirConexion();
                string query = "SELECT * FROM JOBS";
                SqlCommand command = conn.GetCommand(query);

                SqlDataReader records = command.ExecuteReader();

                while (records.Read())
                {
                    int jobId = Convert.ToInt32(records["job_id"]);
                    string jobName = records["job_title"].ToString();
                    decimal? min = records.IsDBNull(records.GetOrdinal("min_salary")) 
                    ? (decimal?)null : records.GetDecimal(records.GetOrdinal("min_salary"));

                    decimal max = 0;

                    Job job = new Job(jobId, jobName, (decimal)min, max);
                    jobs.Add(job);
                }
                records.Close();
                conn.CerarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return jobs;
        }

        public void SaveJob(Job j)
        {
            string cadena = @"
INSERT INTO jobs(job_title,min_salary,max_salary)
VALUES (@ptitle,@pmin,@pmax)"
            ;

            try
            {
                conn.AbrirConexion();
                SqlCommand insert = conn.GetCommand(cadena);

                SqlParameter ptitle = new SqlParameter("@ptitle", SqlDbType.VarChar, 35);
                insert.Parameters.Add(ptitle);
                ptitle.Value = j.Title;

                SqlParameter pmin = new SqlParameter("@pmin", SqlDbType.Decimal);
                insert.Parameters.Add(pmin);
                pmin.Precision = 8;
                pmin.Scale = 2;
                pmin.Value = j.MinSal;

                SqlParameter pmax = new SqlParameter("@pmax", SqlDbType.Decimal);
                insert.Parameters.Add(pmax);
                pmax.Precision = 8;
                pmax.Scale = 2;
                pmax.Value = j.MaxSal;

                insert.ExecuteNonQuery();
                conn.CerarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
