using System;
using System.ComponentModel;
using MyDBOffset;
using Orient.Client;

namespace DAO
{
    class GraphDB : iPersonDAO
    {
      //  OClient.CreateDatabasePool(" 127.0.0.1 " , 2424 , " TestDatabaseName " ,  ODatabaseType.Graph, " admin " , " admin " , 10 ,  " myTestDatabaseAlias " );
        ODatabase database = new ODatabase("myTestDatabaseAlias");
        // some code dealing with database instance
         // or database.Dispose()

        public void create(Person p)
        {
            database.Close();
            throw new NotImplementedException();
        }

        public void delete(Person p)
        {
            
        }

        public BindingList<Person> read()
        {
            throw new NotImplementedException();
        }

        public void update(Person p)
        {
            throw new NotImplementedException();
        }
    }
}
