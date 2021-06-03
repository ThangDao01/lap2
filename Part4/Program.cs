using System;
using System.Text;
using Part4.Properties;

namespace Part4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            if (P4Controller.CheckSin())
            {
                Console.WriteLine("Mã SIN hợp lệ");
            }
            else
            {
                Console.WriteLine("Mã SIN không hợp lệ");
            }
        }
    }
}