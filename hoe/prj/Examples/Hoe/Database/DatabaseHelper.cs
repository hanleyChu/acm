using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
using Hoe.Basic.Model;

namespace Hoe.Basic.DB
{
    public class DatabaseHelper
    {
        private static MongoServer server;
        public static MongoServer Server
        {
            get
            {
                if (server == null)
                {
                    String connectionString = "mongodb://localhost";
                    server = new MongoClient(connectionString).GetServer();
                }
                return server;
            }
        }

        public static bool IsDatabaseAlive()
        {
            try
            {
                Server.Ping();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public static MongoDatabase Database
        {
            get
            {
                return Server.GetDatabase("Hoe");
            }
        }

        public static MongoCollection BillCollection
        {
            get
            {
                return Database.GetCollection<Bill>("bills");
            }
        }

        public static MongoCollection ProductCollection
        {
            get
            {
                return Database.GetCollection<Product>("products");
            }
        }

        public static List<T> MongoCursor2List<T>(MongoCursor mc)
        {
            List<T> objs = new List<T>();

            foreach (T obj in mc)
            {
                objs.Add(obj);
            }

            return objs;
        }
    }
}
