using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Choices
    {
        public static void ProcessingChoices(int Ch)
        {
            switch (Ch)
            {
                case 1:
                    UngEllPen();
                    break;
                case 2:
                    UpprepaTioGnger();
                    break;
                case 3:
                    DetTredjeOrdet();
                    break;
                case 4:
                    HowManyEMployees();
                    break;
                default:
                    break;
            }
        }
        static int ConvertAge(string A)
        {
        NewTry:
            Console.WriteLine("Please enter "+A+":");
            string StringAge = Console.ReadLine();
            int Intage;
            try
            {
                Intage = Convert.ToInt32(StringAge);
            }
            catch
            {
                Console.WriteLine("Please enter "+A+":");
                goto NewTry;
            }
            return Intage;
        }

        public static void UngEllPen()
        {
            int Age = ConvertAge("The Age");
            if (Age < 0)
            {
                Console.WriteLine(" this is not Age, its a negative number");
            }
            else if ((Age < 5) || (Age > 100))
            {
                Console.WriteLine("Det är Gratis");
            }
            else if (Age < 20)
            {
                Console.WriteLine("Ungdomspris: 80Kr");
            }
            else if (Age > 64)
            {
                Console.WriteLine("Pensionärspris: 90Kr");
            }
            else
                Console.WriteLine("Standardpris: 120Kr");
        }
        public static void UpprepaTioGnger()
        {
            Console.WriteLine(" Please enter your text that you need to write it 10 times:");
            string Text = Console.ReadLine();
            for (int I = 1; I <= 10; I++)
            {
                if (I == 10)
                {
                    Console.Write(I + "." + Text + ".");
                } else
                    Console.Write(I + "." + Text + ",");
            }

        }
        public static void DetTredjeOrdet()
        {
        NewTry2:
            Console.WriteLine("Please enter your sentense with three words or more:");
            string Sentense = Console.ReadLine();
            string[] Words = Sentense.Split(' ');
            if (Words.Length < 3)
            {
                Console.WriteLine("You have to write sentense with three words or more");
                goto NewTry2;
            }
            Console.Write("The third word in your sentense is :");
            Console.WriteLine(Words[2]);
        }
        public static void HowManyEMployees()
            {
            string Word = "The number";
            Console.Write("You can write the total of your company's employees,");
            int Total = Choices.ConvertAge(Word);
            Console.Write("You can write the total of your company's employees who are under 20 Year old,");
            int Under= Choices.ConvertAge(Word);
            Console.Write("You can write the total of your company's employees who are over 75 Year old,");
            int Over = Choices.ConvertAge(Word);
            if (Total >= Under + Over)
            {
                int TotalPrice = (Under * 80) + (Over * 90) + ((Total - (Under + Over)) * 120);
                Console.WriteLine("The total price should you pay is:"+TotalPrice);
            }
            else
                Console.WriteLine("wrong entry");
        }
    }
}
  
