// See https://aka.ms/new-console-template for more information

using System.Transactions;
using WT_Demo_Day2;

Console.WriteLine("Hello, World!");



Product product = new Product()
{
    Name = "car",
    Price = 100,

};
decimal totalPrice = (decimal)(new Product()
{
    Name = "car",
    Price = 100,
});



/*
 * Exception Handling
 * Conversion Types
 * Casting operator
 */

#region Object

// C# is full object oriented programming
// is a object 
//object o = new object();


//Product p = new Product();
//int i = 100;
//Console.WriteLine(i.ToString());

//// hashing for the object
//Console.WriteLine(p.GetHashCode());
//Product p2 = new Product();
//Console.WriteLine(p2.GetHashCode());

//int k = 10;
//int l = 10;
//Console.WriteLine(k.Equals(l));


//p.Name = "Car";
//p.Price = 1000;
//p.Category = "Used";

//p2.Name = "Car";
//p2.Price = 1000;
//p2.Category = "Used3";


//Console.WriteLine(p.Equals(p2));
//Console.WriteLine( p.Name == p2.Name && p.Price == p2.Price && p.Category == p2.Category );

// == operaror

//object obj = new Product();

//Product myp = (Product)obj;

//object obj2 = new object();

//Product myp2 = (Product)obj2; // invalid Casting Exception


/*
 * SOLID principles
 * S : single responsability principle
 * o : open closed principle
 * L : Liscov substitution principle
 * I : Interface segregation
 * D : Dependency Inversion
 */


//child c = new child();
//p.printOwner(c);

#endregion

#region stack

//Stack_imp stack = new Stack_imp();

//try
//{
//    stack.Push(1);
//    stack.Push(2);
//    stack.Push(3);
//    stack.Push(4);
//    stack.Push(5);
//    stack.Push(6);
//}
//catch 
//{
//    Console.WriteLine("Stack is full");
//}
//try
//{
//    Console.WriteLine(stack.Pop());
//    Console.WriteLine(stack.Pop());
//    Console.WriteLine(stack.Pop());
//    Console.WriteLine(stack.Pop());
//    Console.WriteLine(stack.Pop());
//    Console.WriteLine(stack.Pop());
//}
//catch
//{
//    Console.WriteLine("Stack is empty");
//}

//stack.Push(6);

//bool cont = false;
//do
//{
//    Console.WriteLine("Enter 1 to push, Enter 2 to pop");
//    int val = int.Parse(Console.ReadLine());
//    switch (val)
//    {
//        case 1:
//            Console.WriteLine("Enter value to push in stack:");
//            int val2 = int.Parse(Console.ReadLine());
//            stack.Push(val2);
//            break;
//        case 2:
//            Console.WriteLine(stack.Pop());
//            break;
//    }
//    Console.WriteLine("Do you want to continue? y/n");
//    string res = Console.ReadLine();
//    if (res == "Y" || res == "y") cont = true;
//    else cont = false;
//} while (cont);
#endregion

#region var

// var determine data type in runtime 
//var x = 3;
//var y = new Product();

//var e = 34;

#endregion

#region Generics
// class Dt when creating object.

//Stack_Generic<string> stack_string = new Stack_Generic<string>(3);
//stack_string.Push("str 1");
//Console.WriteLine(stack_string.Pop());

//Stack_Generic<int> stack_Integer = new Stack_Generic<int>(4);
//stack_Integer.Push(2);
//Console.WriteLine(stack_Integer.Pop());

#endregion

#region Collections


#region List
//List<string> strings = new List<string>();

//List<int> ints = new List<int>();
//Console.WriteLine(ints.Count());

//ints.Add(5);
//ints.Add(4);

//Console.WriteLine(ints.Count());
//ints.Remove(5);
//Console.WriteLine(ints.Count());

//int[] arr = { 1, 2, 3 };
//ints.AddRange(arr);
//Console.WriteLine(ints.Count());

//ints.Insert(3, 10);
//ints.RemoveAt(4);
////ints.InsertRange(2, arr);


//ints.Clear();
//Console.WriteLine("*** Print List: ");
//foreach(int val in ints)
//{
//    Console.WriteLine(val);
//}


//bool cont = false;
//do
//{
//    Console.WriteLine("Enter an integer Value:");
//    int val = int.Parse(Console.ReadLine());
//    ints.Add(val);
//    Console.WriteLine("Do you want to add more? y/n");
//    string res = Console.ReadLine();
//    if (res == "y" || res == "Y") cont = true;
//    else cont = false;
//} while (cont);

//Console.WriteLine("*** Print List you have entered: ");

//ints.Remove(5);
//foreach (int val in ints)
//{
//    Console.WriteLine(val);
//}

//List<string> strings = new List<string>()
//{
//    "ola" , "Ahmed" , "Mona"
//};
//List<Product> products = new List<Product>()
//{
//    new Product(){Name="Car",Price=1000},
//    new Product(){Name="Phone", Price=2000}
//};


//strings.Add("Mohamed");

//products.Add(new Product() { Name = "Dish", Price = 500 });

//Product product1 = new Product();
//Console.WriteLine("Enter product name");
//product1.Name = Console.ReadLine();

//Console.WriteLine("Enter prodcut price");
//product1.Price = int.Parse(Console.ReadLine());

//products.Add(product1);


//Console.WriteLine(products[0]);
//Console.WriteLine(products[1]);
//Console.WriteLine(products[products.Count - 1]);
#endregion

/*
 * List
 * index   value
 *  0       1
 *  1       5
 */



#region Dictionary
/*
 * Dictionary
 * Key         Value
 * (unique)
 */
#endregion

#region Stack<>

#endregion

#region Queue<>

#endregion

#endregion


/*
 * Implement Queue 
 *    Generic
 *    List
 *    ToString() return string
 */

// Main Something like this

//bool cont = false;
//do
//{
//    Console.WriteLine("Enter 1 to push, Enter 2 to pop");
//    int val = int.Parse(Console.ReadLine());
//    switch (val)
//    {
//        case 1:
//            Console.WriteLine("Enter value to push in stack:");
//            int val2 = int.Parse(Console.ReadLine());
//            stack.Push(val2);
//            break;
//        case 2:
//            Console.WriteLine(stack.Pop());
//            break;
//    }
//    Console.WriteLine("Do you want to continue? y/n");
//    string res = Console.ReadLine();
//    if (res == "Y" || res == "y") cont = true;
//    else cont = false;
//} while (cont);