using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDBOffset;
using StackExchange.Redis;

namespace DAO
{
    class RedisPersonDB : iPersonDAO
    {
        ConnectionMultiplexer redis;
        IDatabase db;
        public RedisPersonDB()
        {
            redis = ConnectionMultiplexer.Connect("localhost");
            db = redis.GetDatabase(1);
        }
        public void create(Person p)
        {
            db.ListRightPush("id", p.id);
            db.ListRightPush("fname", p.fname);
            db.ListRightPush("lname", p.lname);
            db.ListRightPush("age", p.age);
        }
        public void delete(Person p)
        {
            RedisValue[] ids = db.ListRange("id");
            RedisValue[] firstNames = db.ListRange("fname");
            RedisValue[] lastNames = db.ListRange("lname");
            RedisValue[] ages = db.ListRange("age");
            for (int i = 0; i < ids.Length; i++)
            {
                if (int.Parse(ids[i].ToString()) == p.id)
                {
                    db.ListRemove("id", ids[i]);
                    db.ListRemove("fname", firstNames[i]);
                    db.ListRemove("lname", lastNames[i]);
                    db.ListRemove("age", ages[i]);
                }
            }
        }
        public BindingList<Person> read()
        {
            BindingList<Person> list = new BindingList<Person>();
            RedisValue[] ids = db.ListRange("id");
            RedisValue[] firstNames = db.ListRange("fname");
            RedisValue[] lastNames = db.ListRange("lname");
            RedisValue[] ages = db.ListRange("age");
            for (int i = 0; i < ids.Length; i++)
            {
                list.Add(new Person(int.Parse(ids[i].ToString()), firstNames[i].ToString(), lastNames[i].ToString(), int.Parse(ages[i].ToString())));
            }
            return list;
        }
        public void update(Person p)
        {
            RedisValue[] ids = db.ListRange("id");
            for (int i = 0; i < ids.Length; i++)
            {
                if (int.Parse(ids[i].ToString()) == p.id)
                {
                    db.ListSetByIndex("fname", i, p.fname);
                    db.ListSetByIndex("lname", i, p.lname);
                    db.ListSetByIndex("age", i, p.age);
                }
            }
        }
    }
}
