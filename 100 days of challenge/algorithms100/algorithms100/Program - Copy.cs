using System;
namespace PrivateConstructorDemo
{
    class Program
    {
        //Private Constructor
        private Program()
        {
            Console.WriteLine("This is Private Constructor");
        }
        public void Method1()
        {
            Console.WriteLine("Method1 is Called");
        }

        static void Main(string[] args)
        {
            //Creating instance of Program class using Private Constructor
            Program obj = new Program();
            Console.ReadKey();
        }
    }
}