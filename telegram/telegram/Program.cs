using System;
//using Telegram.Bot;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using System.Threading.Tasks;

namespace telegram
{
    class Program : BroKhanBot
    {
        
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

