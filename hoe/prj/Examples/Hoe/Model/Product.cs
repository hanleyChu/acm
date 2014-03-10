using System;
using System.Collections.Generic;
using MongoDB.Bson;

namespace Hoe.Basic.Model
{
    public class Product:ICloneable
    {
        //public static List<Product> Products = new List<Product>
        //{
        //    new Product
        //    {
        //        Name = "红木",
        //        Norm = "B102",
        //        Material = "1号", 
        //        Quantity = 10,
        //        Remark = "订单1"
        //    },
        //    new Product
        //    {
        //        Name = "檀木",
        //        Norm = "A12039",
        //        Material = "2号", 
        //        Quantity = 8,
        //        Remark = "订单2"
        //    },
        //    new Product
        //    {
        //        Name = "香格里拉",
        //        Norm = "A129",
        //        Material = "1号", 
        //        Quantity = 5,
        //        Remark = "订单3"
        //    },
        //};

        public ObjectId Id { get; set; }
        public String Name{set; get;}
        public String Norm { set; get; }
        public String Material { set; get; }
        public int Quantity { set; get; }
        public int Demand { set; get; }
        public String Remark { set; get; }
        public float UnitPrice { set; get; }

        public object Clone()
        {
            return this.MemberwiseClone(); //浅复制
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;
            Product p = obj as Product;
            if (this.Name.Equals(p.Name) &&
                this.Material.Equals(p.Material) &&
                this.Norm.Equals(p.Norm))
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
 	         return this.Material.GetHashCode()+this.Name.GetHashCode()+this.Norm.GetHashCode();
        }

    }
}
