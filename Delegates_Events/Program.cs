using Delegates_Events.Events;

namespace Delegates_Events
{
    internal class Program
    {
        public delegate void ProductDel(Product product);

        public delegate int Calculations(int a, int b);
        static void Main(string[] args)
        {
            #region Delegate
            //Delegate => refrence to a function

            //Product product;
            //product = new Product(){Id = 1,Name = "Car", Price = 2000};

            //// PrintName(product);

            //ProductDel productDel;
            //productDel = PrintName;

            //productDel += PrintPrice;

            ////Anonymous Function
            //// Function definition inside delegate 
            //// calling using delegate

            //productDel += delegate (Product product)
            //{
            //    Console.WriteLine($"Anonymous function\n product name = {product.Name}, product price = {product.Price}");
            //};

            //// Lambda expression
            //// => lambda operator
            //productDel += (Product product) => {
            //    Console.WriteLine("Lambda expression");
            //    Console.WriteLine($"product name = {product.Name}, product price = {product.Price}");
            //};
            //productDel += (product) => Console.WriteLine($"One line lambda expression => {product.Name}");

            //productDel(product);

            //Calculations calculations;
            //calculations = Sum;

            ////int sum =  calculations(5, 6);
            ////Console.WriteLine(sum);

            ////Anonymus function
            //calculations += delegate (int a, int d)
            //{
            //    return a - d;
            //};

            ////lambda expression
            //calculations += (a, b) => a * b;
            //calculations += (a, b) => {
            //    Console.WriteLine("test");
            //    return a * b;
            //    };

            //Console.WriteLine(calculations(6,5)); // return a-b
            #endregion

            #region shop
            //Shop shop = new Shop();

            ////shop.PrintProducts();

            //Product product = new Product()
            //{
            //    Id = 1,
            //    Name = "Car",
            //    Price = 1000
            //};

            //shop.AddProduct(product);
            //shop.PrintProducts();
            //Console.WriteLine(shop.TotalPrice());


            //shop.RemoveProductByIndex(2);
            //shop.RemoveProductByIndex(0); 
            ////shop.RemoveProductByIndex(1);
            //shop.PrintProducts();

            //Console.WriteLine(shop.TotalPrice());


            //Console.WriteLine($"TotalDiscount = {shop.TotalDiscount(DiscountFunction)}");

            ////CRUD operation
            //// c: Create
            //// R: Read
            //// U: Update
            //// D: Delete

            //do
            //{
            //    //DisplayMenu()

            //    // 1 : Show Products
            //    // 2 : Add product
            //    // 3 : Delete Product
            //    // 4 : Update Product
            //    // 5 : Total Price
            //    // 6 : Total Discout
            //    // 0 : Exit

            //    // Read choice from user

            //    //switch(choice)
            //    /*
            //     * case 0 : Environment.Exit(0);
            //     * case 1 : shop.PrintProducts();
            //     * case 2 : shop.AddProduct();
            //     * case 3 : shop.RemoveProductById(int);  shop.RemoveProductByIndex(int);
            //     * case 4 : shop.UpdateProduct(int,string,int);
            //     * case 5 : shop.TotalPrice()
            //     * case 6 : shop.TotalDiscount(delegate)
            //     * finally: continue;
            //     */
            //} while (true);
            #endregion


            #region Events

            Groom Ahmed = new Groom("Ahmed");


            Relative Mona = new Relative("Mona");
            Relative Omar = new Relative("Omar");

            Ahmed.Wedding += Mona.GetNotifed;
            Ahmed.Wedding += Omar.GetNotifed;

            Ahmed.SendInventations(DateTime.Now.AddDays(30));

            Groom Ali = new Groom("Ali");

            Relative Maged = new Relative("Maged");
            Ali.Wedding += Maged.GetNotifed;

            Ali.SendInventations(DateTime.Now.AddDays(45));

            #endregion

            #region Built-in Delegates
            //Action
            // Delegate with one upto 16 prameter and no return type
            Action<Product> productActionDel;
            productActionDel = PrintPrice;
            productActionDel += PrintName;
            productActionDel(new Product() { Id =1,Name="car",Price=200});

            //Func
            // Delegate with zero upto 16 parameter with return
            Func<int, int, int> calcFuncDel;
            calcFuncDel = Sum;
            Console.WriteLine(calcFuncDel(5,9));

            //Predicate
            // Delegate with one parameter with bool return
            Predicate<Product> FilterProducts;
            FilterProducts = (p) => p.Price < 1000;

            Shop shop = new Shop();
            foreach(var item in shop.products)
            {
                if (FilterProducts(item)) Console.WriteLine(item);
            }

            #endregion
        }

        public static int DiscountFunction(int price)
        {
            if (price < 700)
                return 100;
            else if (price < 1200)
                return 200;
            else if (price < 3000)
                return 300;
            else
                return 1000;
        }
        public static void PrintName (Product product)
        {
            Console.WriteLine(product.Name);
        }

        public static void PrintPrice(Product product)
        {
            Console.WriteLine(product.Price);
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}