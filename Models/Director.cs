using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory.Models
{
    public class Director
    {
        public string fname;
        public string lname;
        public int yearofbirth;
        public int timeatwork;

        public Director(string fname, string lname, int yearofbirth, int timeatwork)
        {
            this.fname = fname;
            this.lname = lname;
            this.yearofbirth = yearofbirth;
            this.timeatwork = timeatwork;
        }
    }
}