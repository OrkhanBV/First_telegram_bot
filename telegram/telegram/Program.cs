using System;
//using Telegram.Bot;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using System.Threading.Tasks;

namespace telegram
{
    class Program : Message_handler
    {
        const string TOKEN = "";
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    GetMessages().Wait();
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error:" + e);
                }
            }
        }
    }
<<<<<<< HEAD
}
=======

}
>>>>>>> 1c2f17620a8267d81ed1ea05c13f0b77111eb4ff
