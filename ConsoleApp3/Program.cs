using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static int n;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            getN();
            printAnswer();
            Console.ReadKey();
        }
        public static void getN()
        {
            bool nValueInvalid = true;
            while (nValueInvalid == true)
            {
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    nValueInvalid = false;
                    if (n < 0) { Console.WriteLine("Число n не может быть отрицательным"); nValueInvalid = true; }
                }
                catch (FormatException)
                {
                    Console.Write("Неверный символ" + "\r\n"); nValueInvalid = true;
                }
            }
        }
        public static void printAnswer()
        {
            if ((n % 10 == 1) && (n != 11)) { Console.WriteLine(n + " программист"); }
            if ((n % 10 == 0) || ((n >= 11) && (n <= 14)) || ((n % 10 >= 5) && (n % 10 <= 9))) { Console.WriteLine(n + " программистов"); }
            if ((n % 10 >= 2) && (n % 10 <= 4) && (n != 12) && (n != 13) && (n != 14)) { Console.WriteLine(n + " программиста"); }
        }
    }
}
