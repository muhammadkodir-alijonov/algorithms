//using System;
//namespace InheritanceDemo
//{
//    class A
//    {
//        public void Method1()
//        {
//            Console.WriteLine("Method 1");
//        }
//        public void Method2()
//        {
//            Console.WriteLine("Method 2");
//        }
//    }
//    class B : A
//    {
//        static void Main()
//        {
//            B obj = new B();
//            obj.Method1();
//            obj.Method2();
//            Console.ReadKey();
//        }
//    }
//}

//using System;
//using System.Collections;
//namespace ArayDemo
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Creating a Collection using Array List
//            ArrayList numberArray = new ArrayList();
//            numberArray.Add(10);
//            numberArray.Add(200);
//            numberArray.Add("asfd");

//            //No CompileTime Error
//            numberArray.Add("Pranaya");

//            //We Get Runtime Error, when we access the 3rd Element
//            foreach (int no in numberArray)
//            {
//                Console.WriteLine(no);
//            }

//            Console.ReadKey();
//        }
//    }
//}


//using System;

//class MultiplicationTables
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Input the numbers (Tables to be calculated) separated by commas (e.g., 2,3,4,5,6,7,8,9,10): ");
//        string input = Console.ReadLine();
//        string[] numbers = input.Split(',');

//        foreach (string numberStr in numbers)
//        {
//            if (int.TryParse(numberStr, out int number))
//            {
//                Console.WriteLine($"\nMultiplication Table for {number}:\n");
//                for (int i = 1; i <= 10; i++)
//                {
//                    int result = number * i;
//                    Console.WriteLine($"{number} X {i} = {result}");
//                }
//            }
//            else
//            {
//                Console.WriteLine($"Invalid input: {numberStr} is not a valid number.");
//            }
//        }
//    }
//}

using System;
namespace ComparisionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            object name = "sandeep";
            char[] values = { 's', 'a', 'n', 'd', 'e', 'e', 'p' };
            object myName = new string(values);
            Console.WriteLine("== operator result is {0}", name == myName);
            Console.WriteLine("Equals method result is {0}", myName.Equals(name));
            Console.ReadKey();
        }
    }
}