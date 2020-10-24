using System;
//using Telegram.Bot;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using System.Threading.Tasks;

namespace telegram
{
    class Program : Message_handler
    {
        const string TOKEN = "1307823169:AAEhyMxnJXAnQJWONwCg2keQFbAW2-j4NTA";
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
}