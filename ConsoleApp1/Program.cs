using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Program
    {
        public bool IsValid(int opt)
        {
            if (opt > 100)
            {
                return true;
            }
            return false;
        }
        public int AddData(int a, int b)
        {
            return (a + b);
        }
        static void Main(string[] args)
        {
        }
    }
}
