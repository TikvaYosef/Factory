using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory.Models
{
    public class Employy
    {
        public string fname;
        public string lname;
        public int yearofbirth;
        public int phone;

        public Employy(string fname, string lname, int yearofbirth, int phone)
        {
            this.fname = fname;
            this.lname = lname;
            this.yearofbirth = yearofbirth;
            this.phone = phone;
        }
    }
}