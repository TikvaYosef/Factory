using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory.Models
{
    public class Inspector
    {
        public string fname;
        public string lname;
        public string class_;
       

        public Inspector(string fname, string lname, string class_)
        {
            this.fname = fname;
            this.lname = lname;
            this.class_ = class_;
           
        }
    }
}