using System;
using System.Collections.Generic;
using Hoe.Basic.Model;
using Hoe.Basic.DB;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;
using System.Linq;

namespace Hoe.Basic.DAO
{
    public class BillDao
    {
        public static List<Bill> GetAll()
        {
            List<Bill> bills = new List<Bill>();
            MongoCursor mc = DatabaseHelper.BillCollection.FindAllAs<Bill>();

            foreach (Bill bill in mc)
            {
                bills.Add(bill);
            }

            if (bills.Count > 0)
                return bills;
            else
                return null;
        }

        public static void Insert(Bill bill)
        {
            DatabaseHelper.BillCollection.Insert<Bill>(bill);
        }

        public static void Update(Bill bill)
        {
            DatabaseHelper.BillCollection.Save<Bill>(bill);
        }

        public static void Delete(Bill bill)
        {
            DatabaseHelper.BillCollection.Remove(Query<Bill>.EQ(e => e.Id, bill.Id));
        }

        public static List<Bill> FindByPhone(String phone)
        {
            
            MongoCursor mc = DatabaseHelper.BillCollection.FindAs<Bill>(Query.EQ("Phone",phone));
            List<Bill> bills = DatabaseHelper.MongoCursor2List<Bill>(mc);

            if (bills.Count > 0)
                return bills;
            else
                return null;

        }

        public static List<Bill> FindByPhone(String phone, bool completed)
        {
            MongoCursor mc = DatabaseHelper.BillCollection.FindAs<Bill>(Query.And(
                Query.EQ("Phone", phone),
                Query.EQ("Completed", completed)
                )
            );
            List<Bill> bills = DatabaseHelper.MongoCursor2List<Bill>(mc);

            if (bills.Count > 0)
                return bills;
            else
                return null;

        }

        public static List<Bill> Find(bool completed)
        {
            MongoCursor mc = DatabaseHelper.BillCollection.FindAs<Bill>(
                Query.EQ("Completed", completed)
            );
            List<Bill> bills = DatabaseHelper.MongoCursor2List<Bill>(mc);

            if (bills.Count > 0)
                return bills;
            else
                return null;

        }

        public static List<Bill> FindByProductName(String name, bool completed)
        {
            var result = from e in DatabaseHelper.BillCollection.AsQueryable<Bill>()
                where e.Products.Any<Product>(x => x.Name == name) && e.Completed == completed
                select e;
            List<Bill> bills = result.ToList<Bill>();

            if (bills == null || bills.Count == 0)
                return null;
            else
                return bills;
        }

        public static List<Bill> FindByProductName(String name)
        {
            var result = from e in DatabaseHelper.BillCollection.AsQueryable<Bill>()
                         where e.Products.Any<Product>(x => x.Name == name)
                         select e;
            List<Bill> bills = result.ToList<Bill>();

            if (bills == null || bills.Count == 0)
                return null;
            else
                return bills;
        }
    }
}
