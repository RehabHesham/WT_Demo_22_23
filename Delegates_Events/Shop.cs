using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Events
{
    internal class Shop
    {
        public delegate int DiscountDel(int price);
        private int NextId;
        public List<Product> products { get; set; }
        public Shop() { 
           products= new List<Product>()
           {
               new Product(){Id = 1, Name = "Phone", Price=2000},
               new Product(){Id = 2, Name = "Orange", Price=20},
               new Product(){Id = 3, Name = "bike", Price=500}
           };
            NextId = 4;
        }
        
        // read
        public void PrintProducts()
        {
            Console.WriteLine("\n\n===> Product List");
            int i = 0;
            foreach(var item in products)
            {
                Console.WriteLine( $"{i++} :"+item);
            }
        }
        // create
        public void AddProduct(Product product)
        {
            product.Id = NextId++;
            products.Add(product);
        }

        //Update
        public void UpdateProduct(int index,Product product) {
            products[index].Price = product.Price;
            products[index].Name = product.Name;
        }

        // Delete
        public void RemoveProductByIndex(int index)
        {
            products.RemoveAt(index);
        }
        public void RemoveProductById(int id)
        {
            Product product= null;
            foreach(var item in products)
            {
                if(item.Id == id) { product = item; break; }
            }
            if(product != null)  products.Remove(product);
        }

        // Business logic
        public int TotalPrice() {
            int sum = 0;
            foreach(var item in products)
            {
                sum += item.Price;
            }
            return sum;
        }

        // Business logic
        public int TotalDiscount(DiscountDel discountDel)
        {
            int totalPrice = TotalPrice();
            Console.WriteLine($"Total price = {totalPrice}");
            return discountDel(totalPrice);
        }
    }
}
