using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MyDBOffset;
using MySql.Data.MySqlClient;

namespace DAO
{
    class My_SQL_Person : iPersonDAO
    {
        private BindingList<Person> outSidelist = new BindingList<Person>();
        MySqlConnection connect = new MySqlConnection("Server=localhost;Database=mysqldb; Uid=root;Pwd=1111;");
        MySqlConnectionStringBuilder dddd = new MySqlConnectionStringBuilder();
        MySqlCommand cmd;
        string qwery;

        public void create(Person p)
        {
            connect.Open();
            qwery = "insert Person ( fname, lname, age) values('" + p.fname + "', '" + p.lname + "', '" + p.age + "');";
            cmd = new MySqlCommand(qwery, connect);
            int d = cmd.ExecuteNonQuery();
            p.id = d;
            connect.Close();
        }

        public void delete(Person p)
        {
            connect.Open();
            qwery = "DELETE FROM Person WHERE id=" + @p.id;
            cmd = new MySqlCommand(qwery, connect);
            cmd.ExecuteNonQuery();
            connect.Close();
        }

        public BindingList<Person> read()
        {
            outSidelist.Clear();
            connect.Open();
            qwery = "Select * From Person";
            cmd = new MySqlCommand(qwery, connect);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                outSidelist.Add(new Person(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3)));
            }
            connect.Close();
            return outSidelist;
        }

        public void update(Person p)
        {
            connect.Open();
            qwery = @"UPDATE Person SET fname='" + @p.fname + @"', lname='" + @p.lname + @"', age='" + @p.age + @"' WHERE id='" + @p.id + "';";
            cmd = new MySqlCommand(qwery, connect);
            cmd.ExecuteNonQuery();
            connect.Close();
        }
    }
}
