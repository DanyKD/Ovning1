using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class HuvudMeny
    {
        public static void Welcome()
        {
            Console.WriteLine("  ******** Välkmona till min första programmet ********  ");
            //Console.WriteLine("Du ska Navigera en meny genom att skriva in siffror:");
            Console.WriteLine("Tryck 0 om du vill logga ut:");
            Console.WriteLine("tryck på valfri tangent för att fortsätta:");
            string Continue = Console.ReadLine();
            if (Continue != "0")
            {
               StartProgram();
            }

        }
        public static int EnterYourChoice()
        {
            NewTry3:
            Console.WriteLine(" ");
            Console.WriteLine(" välj ditt val");
            Console.WriteLine("0 : Utgång");
            Console.WriteLine("1 : Ungdom eller penionär");
            Console.WriteLine("2 : Upprepa tio gånger" );
            Console.WriteLine("3 : Det tredje ordet");
            Console.WriteLine("4 : Total Price to Go to the Cenima");
            string a= Console.ReadLine();
            int C;
            try
            {
                C = Convert.ToInt32(a);
            }
            catch
            {
                Console.WriteLine("You have to choose from 1 to 3");
                goto NewTry3;
            }
             return C;
        }
        public static void StartProgram()
        {
            //int Choice =EnterYourChoice();
            int Choice;
            do
            {
                Choice = EnterYourChoice();
                Choices.ProcessingChoices(Choice);
                //string result = MessageBox.Show("Do you want to choose one more time(Y/N)?", "Exit or not?", MessageBoxButtons.YesNo);

            } while (Choice != 0);
            return ;
        }
    }
    
}
    
