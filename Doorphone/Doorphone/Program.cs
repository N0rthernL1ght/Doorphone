using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doorphone
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int a = 123;
            int input;
            int password=0;
            int b;
            Doorphone dp = new Doorphone();
            
            //Doorphone dp = new Doorphone();
            while (password!=a){
                //Doorphone dp = new Doorphone();
                Console.WriteLine("Выберите действие: 1-ввести пароль 2 - позвонить вахтеру");
                input = Convert.ToInt32(Console.ReadLine());
                
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Enter password");
                        password = Convert.ToInt32(Console.ReadLine());
                        dp.Watchpas(password);
                        break;
                    case 2:
                        Console.WriteLine("Who a you?");
                        Console.WriteLine("Your choice: 1 - true 2 - lie");
                        b = Convert.ToInt32(Console.ReadLine());
                        dp.Say(b);
                        break;
                    default:
                        Console.WriteLine("Выберите действие: 1-ввести пароль 2 - позвонить вахтеру");
                        break;
                }
            } 
        
            Console.ReadKey();

        }
    }
}