using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any number from 100 to 999: ");
            string userInput = Console.ReadLine();

            try
            {
                int number = int.Parse(userInput);

                GroupOfNumber(number, out string num);

                if (num == "Even")
                {
                    string hundredth = number.ToString().Substring(0, 1);
                    string tenth = number.ToString().Substring(1, 1);
                    string oneth = number.ToString().Substring(2);

                    Console.Write("You entered " + number + " which consist of ");
                    Console.WriteLine(hundredth + "x100 + " + tenth + "x10 + " + oneth + "x1");
                }

                else if (num == "Odd")
                {
                    DateTime day = DateTime.Now;
                    day = day.AddDays(number);
                    Console.WriteLine(number + " days from today is at " + day);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("The input must be a number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry. Unexpected error: {0}", ex.Message);
            }
            

            //Console.Write(num);

            Console.ReadLine();
        }

        static string GroupOfNumber(int number, out string num) => num = (number % 2 != 0) ? "Odd" : "Even";
    }
}
