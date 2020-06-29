using System;

namespace UNitTest
{
    class Program
    {
        public bool IsValid(int opt)
        {
            if (opt > 100)
            {
                return true;
            }
            return false;
        }
        public int AddData(int a,int b)
        {
            return (a + b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
