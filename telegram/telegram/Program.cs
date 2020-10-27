using System;

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

