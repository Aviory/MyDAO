using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDBOffset;

namespace DAO
{
    class EntetyFrDB : iPersonDAO
    {
        private BindingList<Person> outSidelist = new BindingList<Person>();
        private List<Person> innerList = new List<Person>();
        public void create(Person p)
        {
            innerList.Add(p);
        }

        public void delete(Person p)
        {
            Person[] m = innerList.ToArray();
            for (int i = 0; i < m.Length; i++)
            {
                if (m[i].id == p.id)
                {
                    m[i] = null;
                    break;
                }
            }
            innerList.Clear();
            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] != null)
                {
                    innerList.Add(m[i]);
                }
            }
        }

        public BindingList<Person> read()
        {
            EntetyData db = new EntetyData();
            BindingList<Person> lpers = new BindingList<Person>();
            List<PersonDB> tmp = db.PersonDB.SqlQuery("SELECT * FROM dbo.EF_pers").ToList();
            foreach (PersonDB p in tmp)
            {
                outSidelist.Add(new Person(p));
            }
            return outSidelist;
        }

        public void update(Person p)
        {
            foreach (Person pers in innerList)
            {
                if (pers.id == p.id)
                {
                    pers.lname = p.lname;
                    pers.fname = p.fname;
                    pers.age = p.age;
                    return;
                }
            }
        }
    }
}
