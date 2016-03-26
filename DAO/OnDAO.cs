using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class OnDAO
    {
        private static iPersonDAO mock = null;
        private static iPersonDAO MS_SQL = null;
        private static iPersonDAO My_SQL = null;
        private static iPersonDAO mongo = null;
        private static iPersonDAO EntetyFr = null;
        private static iPersonDAO Redis = null;

        public static iPersonDAO ini(string s)
        {
            iPersonDAO inidb = null;
            switch (s)
            {
                case "MS_SQL":
                    if (MS_SQL == null)
                    {
                        inidb = new MS_SQL_Person();
                        MS_SQL = inidb;
                    }
                    else
                    {
                        inidb = MS_SQL;
                    }
                    break;
                case "My_SQL":
                    if (My_SQL == null)
                    {
                        inidb = new My_SQL_Person();
                        My_SQL = inidb;
                    }
                    else
                    {
                        inidb = My_SQL;
                    }
                    break;
                case "Mongo":
                    if (mongo == null)                  //http://metanit.com/nosql/mongodb/4.1.php
                    {
                        inidb = new MongoDB();          //http://www.mongodbmanager.com/download
                        mongo = inidb;
                    }
                    else
                    {
                        inidb = mongo;
                    }
                    break;
                case "EntetyFr":
                    if (EntetyFr == null)                  //http://metanit.com/nosql/mongodb/4.1.php
                    {
                        inidb = new EntetyFrDB();          //http://www.mongodbmanager.com/download
                        EntetyFr = inidb;
                    }
                    else
                    {
                        inidb = EntetyFr;
                    }
                    break;
                case "Redis":
                    if (Redis == null)                  //http://metanit.com/nosql/mongodb/4.1.php
                    {
                        inidb = new RedisPersonDB();          //http://www.mongodbmanager.com/download
                        Redis = inidb;
                    }
                    else
                    {
                        inidb = Redis;
                    }
                    break;
                default:
                    if(mock == null)
                    {
                        inidb = new MockPersonDB();
                        mock = inidb;
                    }
                    else
                    {
                        inidb = mock;
                    }
                    break;
            }
            return inidb;
        }
    }
}
