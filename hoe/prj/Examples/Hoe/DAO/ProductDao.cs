using System;
using System.Collections.Generic;
using Hoe.Basic.Model;
using Hoe.Basic.DB;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;

namespace Hoe.Basic.DAO
{
    public class ProductDao
    {
        public static List<Product> GetAll()
        {
            List<Product> products = new List<Product>();
            MongoCursor mc = DatabaseHelper.ProductCollection.FindAllAs<Product>();

            foreach (Product product in mc)
            {
                products.Add(product);
            }

            if (products.Count > 0)
                return products;
            else
                return null;
        }

        public static List<Product> FindLikeName(String name)
        {
            List<Product> products = new List<Product>();
            MongoCursor mc = DatabaseHelper.ProductCollection.FindAs<Product>(Query.Matches("Name", name));

            foreach (Product product in mc)
            {
                products.Add(product);
            }

            if (products.Count > 0)
                return products;
            else
                return null;

        }

        public static void Insert(Product product)
        {
            DatabaseHelper.ProductCollection.Insert<Product>(product);
        }

        public static void Update(Product product)
        {
            DatabaseHelper.ProductCollection.Save(product);
        }

        public static void Delete(Product product)
        {
            DatabaseHelper.ProductCollection.Remove(Query<Product>.EQ(e => e.Id, product.Id));
        }

        
    }
}
