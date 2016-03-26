using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace MyDBOffset
{
    public class Person
    {
        private PersonDB p;

        public int id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public int age { get; set; }
        public Person()
        {
           
        }
        public Person(int id, string fname, string lname, int age)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;
            this.age = age;
        }

        public Person(PersonDB p)
        {
            this.p = p;
        }
    }
}
