using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ConexionBDEmployee
{
    
    public partial class Form1 : Form
    {
        DALJob jobDAL = new DALJob();
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Min", typeof(decimal));
            dt.Columns.Add("Max", typeof(decimal));

        }

        private void btnCNT_Click(object sender, EventArgs e)
        {
            try
            {
                List<Job> listJob = jobDAL.GetJobs();

                foreach (Job job in listJob) 
                {
                    dt.Rows.Add(new object[] { job.Id, job.Title, job.MinSal, job.MaxSal });
                }
                dataGridView1.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"DB Error: {ex.Number}\n{ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var minSal = tbMinSal.Text;
            decimal? max = string.IsNullOrWhiteSpace(tbMaxSal.Text)
    ? (decimal?)null
    : decimal.Parse(tbMaxSal.Text);

            decimal? min = string.IsNullOrWhiteSpace(tbMinSal.Text)
    ? (decimal?)null
    : decimal.Parse(tbMinSal.Text);
            string tit = tbJob.Text;
            jobDAL.SaveJob(new Job(0, tit, min, max));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Information Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTestLinq_Click(object sender, EventArgs e)
        {
            DataClassDataContext dc = new DataClassDataContext();
            var data1 = dc.employees.Where(query => query.first_name.StartsWith("s")).Select(x => new { x.first_name, x.last_name });
            var data = dc.employees.Select(x => new { x.first_name, x.last_name});
            var data2 = from emp in dc.employees
                        select emp; // new { emp.first_name, emp.last_name};

            foreach ( var emp in data)
            {
                string f = emp.first_name;
                string l = emp.last_name;
            }

            foreach (var emp in data2)
            {
                string f = emp.first_name;
                string l = emp.last_name;
                int? id = emp.employee_id;
            }

            foreach (var emp in data2)
            {
                emp.first_name = "x"+ emp.first_name;
                
            }

        } 
    }
}
