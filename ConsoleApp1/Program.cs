using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Enter a number to findout the factorial....");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            var factorial = p.Factorial(userNumber);
            Console.WriteLine("Factorial of {0} is : {1}", userNumber, factorial);
            Console.ReadKey();

        }

        public int Factorial(int number)
        {
            try
            {
                int temp = 1;
                while (number > 0)
                {
                    temp = temp * number;
                    number--;
                }
                return temp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
