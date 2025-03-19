using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBDEmployee
{
    internal class Job
    {
        private int id;
        private decimal maxSal;
        private decimal minSal;
        private string title;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public decimal MaxSal
        {
            get { return maxSal; }
            set { maxSal = value; }
        }

        public decimal MinSal
        {
            get { return minSal; }
            set { minSal = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public Job(int id, string tit, decimal min, decimal max)
        {
            this.Id = id;
            this.Title = tit;
            this.MinSal = min;  
            this.MaxSal = max;
        }
    }
}
