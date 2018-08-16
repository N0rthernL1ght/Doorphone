using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doorphone
{
    class Doorphone
    {
        private
            int password = 123;
        
        public void Watchpas(int w)
        {
            if (password == w) Console.WriteLine("Welcome");
            else Console.WriteLine("Password invalid");
        }

        public void Say(int p)
        {
            if (p == 1)
            {
                Console.WriteLine("It is Nikita Kochtygov");
                Console.WriteLine("One second");
                Console.WriteLine("oh, Welcome in your new home");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("It is police");
                Console.WriteLine("But nobody call police");
                Console.WriteLine("Goodbye. Go home");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
