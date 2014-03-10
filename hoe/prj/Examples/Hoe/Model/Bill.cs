using System;
using System.Collections.Generic;
using MongoDB.Bson;

namespace Hoe.Basic.Model
{
    public class Bill
    {
        //public static List<Bill> Bills = new List<Bill>
        //{
        //    new Bill
        //    {
        //        Phone = "15158135497",
        //        DeliveryDate = DateTime.Now,
        //        Number = "B0001", 
        //        Remark = "订单1",
        //        Completed = false
        //    },
        //    new Bill
        //    {
        //        Phone = "15158135497",
        //        DeliveryDate = DateTime.Now,
        //        Number = "B0002", 
        //        Remark = "订单2",
        //        Completed = true
        //    },
        //    new Bill
        //    {
        //        Phone = "15158135497",
        //        DeliveryDate = DateTime.Now,
        //        Number = "B0003", 
        //        Remark = "订单3",
        //        Completed = false
        //    },
        //};

        public ObjectId Id { get; set; }
        public String Phone{set; get;}
        public DateTime DeliveryDate { set; get; }
        public String Number { set; get; }
        public String Remark { set; get; }
        public bool Completed { set; get; }
        public float Deposit { set; get; }
        public bool AssemblageOK { set; get; }

        private List<Product> products;

        public List<Product> Products 
        {
            set
            {
                products = value;
            }
            get
            {
                if (products == null)
                {
                    products = new List<Product>();
                }
                return products;
            }
        }

        public override bool Equals(Object obj)
        {
            Bill b = obj as Bill;
            if (this.Number.Equals(b.Number))
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return this.Number.GetHashCode();
        }
    }
}
