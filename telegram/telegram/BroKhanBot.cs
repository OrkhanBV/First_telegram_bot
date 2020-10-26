using System;
using Telegram.Bot;
using System.Threading.Tasks;

/*
 * System.Threading.Tasks
 *
 * Task - тип возвращаемого значения при асинхронном программировани более подробно см по ссылке
 * https://docs.microsoft.com/ru-ru/dotnet/csharp/programming-guide/concepts/async/async-return-types
 * 
 * async
 * await
 * 
 * Всё вышеперечисленное относится к асинхронному программированию
 * Более подробно с примером асинхронного программирования можно ознакомиться
 * по ссылке:
 *
 * https://docs.microsoft.com/ru-ru/dotnet/csharp/programming-guide/concepts/async/
 * 
 */

namespace telegram
{
    public class BroKhanBot 
    {
        private const string TOKEN = ;
            public static async Task GetMessages()
            {
                TelegramBotClient bot = new TelegramBotClient(TOKEN);
                KeyboardButtons buttons = new KeyboardButtons();
                IventHandler iventHandler = new IventHandler();
                int offset = 0;
                int timeout = 0;
                try
                {
                    await bot.SetWebhookAsync("");
                    while (true)
                    {
                        var updates = await bot.GetUpdatesAsync(offset, timeout);
                        foreach (var update in updates)
                        {
                            await buttons.create_buttons(bot, update);
                            await iventHandler.getIventSendLink(bot, update);
                            offset = update.Id + 1;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error :" + e);
                    throw;
                }
            }
    }
}