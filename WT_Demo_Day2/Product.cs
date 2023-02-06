using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WT_Demo_Day2
{
    // OOP Concepts
    // Encapsulation : 
    internal class Product 
    {
        public string Category { get; set; }

        private string name;
        public string Name { get { return name; }
            set { 
                name = value;
            } 
        }

        private int price;
        public int Price { 
            get { return price; } 
            set {
                if (value < 0)
                    throw new Exception("Invalid price");
                else price = value;
            } }
        //public string Print()
        //{
        //    return $"name = {name}, category = {Category}, price = {price}";
        //}

        public override string ToString()
        {
            return $"name = {name}, category = {Category}, price = {price}";
        }

        public override bool Equals(object? obj)
        {
            Product p = (Product)obj;

            return this.Name == p.Name && this.price == p.price && this.Category == p.Category;
        }

        public static explicit operator decimal(Product product)
        {
            return product.price * 0.1M;
        }

        public void printOwner(GF gF)
        {
            Console.WriteLine(gF.ToString());
        }
    }
}
