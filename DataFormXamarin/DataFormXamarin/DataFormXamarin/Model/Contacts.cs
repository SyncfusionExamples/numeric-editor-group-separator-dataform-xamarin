using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DataFormXamarin
{
    public class Contacts
    {
        private String name;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        private int? birthYear;
        public int? BirthYear
        {
            get { return birthYear; }
            set { birthYear = value; }
        }
        private String address;
        public String Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}
