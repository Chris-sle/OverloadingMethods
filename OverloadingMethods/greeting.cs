using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingMethods
{
    internal class greeting
    {
        public void Run()
        {
            PrintWelcomeMessage();
            var userReply = Console.ReadLine();
            PrintWelcomeMessage(userReply);
        }

        private void PrintWelcomeMessage(string? userReply)
        {
            if(userReply != "") Console.WriteLine($"{userReply}");
            Console.WriteLine("Du er snill");
        }

        private void PrintWelcomeMessage()
        {
            Console.WriteLine("Hei og velkommen!");
        }
    }
}
