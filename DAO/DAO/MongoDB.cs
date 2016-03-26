using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDBOffset;
using MongoDB.Driver;
using MongoDB.Bson;

namespace DAO
{
    class MongoDB : iPersonDAO
    {
        public async void init()
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            IMongoDatabase db = client.GetDatabase("mongoData");

            var collection = db.GetCollection<Person>("Person");

            await collection.InsertOneAsync(new Person(10, "Alexander", "Williams", 20));
            await collection.InsertOneAsync(new Person(16, "Andrew", "Grant", 42));
            await collection.InsertOneAsync(new Person(17, "Augusta", "Walter", 25));
            await collection.InsertOneAsync(new Person(18, "Allan", "Smith", 21));
            await collection.InsertOneAsync(new Person(19, "Nik", "Sanders", 32));

        }

        public void create(Person p)
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            IMongoDatabase db = client.GetDatabase("mongoData");
            var collection = db.GetCollection<Person>("Person");
            //await collection.InsertOneAsync(p.id, p.fname, p.lname, p.age);
        }

        public void delete(Person p)
        {
            throw new NotImplementedException();
        }

        BindingList<Person> iPersonDAO.read()
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            IMongoDatabase db = client.GetDatabase("mongoData");
            var collection = db.GetCollection<Person>("Person");

            var filter = new BsonDocument();
            var people = collection.Find(filter).ToList();

            //List<Person> lst = new List<Person>(); 
            //foreach (Person doc in people)
            //{
            //    lst.Add(doc);
            //}
            BindingList<Person> list = new BindingList<Person>();
            foreach (Person p in people)
            {
                list.Add(p);
            }
            return list;
        }

        public void update(Person p)
        {
            throw new NotImplementedException();
        }
    }
}
