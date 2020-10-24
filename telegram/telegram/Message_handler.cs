using System;
using System.Collections.Generic;
using System.Net.Sockets;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
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
    public class Message_handler
    {
        const string TOKEN = "1307823169:AAEhyMxnJXAnQJWONwCg2keQFbAW2-j4NTA";
        
        public static async Task GetMessages( )
        {
            TelegramBotClient bot = new TelegramBotClient(TOKEN);
            RecomendedLinks Links = new RecomendedLinks();
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
                        var message = update.Message;
                        if (message.Text == "/start")
                        {
                            var keybord = new ReplyKeyboardMarkup
                            {
                                Keyboard = new[]
                                {
                                    new[]
                                    {
                                        new KeyboardButton("Материалы С#"),
                                        new KeyboardButton("Материалы SQL"),
                                        new KeyboardButton("Основы Web")
                                    },
                                    new[] { new KeyboardButton("Работа с данными (СУБД + NET)") },
                                    new[] { new KeyboardButton("Паттерны проектирования") },
                                    new[] { new KeyboardButton("Bro button")}
                                }
                            };
                            await bot.SendTextMessageAsync(message.Chat.Id, "Привет Bro" + message.Chat.Username,
                                ParseMode.Html, false, false, 0, keybord);
                        }

                        if (message.Text == "Bro button")
                            await bot.SendTextMessageAsync(message.Chat.Id, "BROOOOOOOOOOOOO");
                        if (message.Text == "Материалы С#")
                            await bot.SendTextMessageAsync(message.Chat.Id, (Links.link1 + Links.link2));
                        if (message.Text == "Материалы SQL")
                            await bot.SendTextMessageAsync(message.Chat.Id, (Links.link3 + Links.link4 + Links.link5));
                        if (message.Text == "Основы Web")
                            await bot.SendTextMessageAsync(message.Chat.Id, (Links.link6 + Links.link7 + Links.link8 
                            + Links.link9 + Links.link10 + Links.link11 + Links.link12 
                            + Links.link13 + Links.link14 + Links.link15 + Links.link16
                            + Links.link17 + Links.link18 + Links.link19 + Links.link20
                            + Links.link21 + Links.link22 + Links.link23 + Links.link24));
                        if (message.Text == "Паттерны проектирования")
                        {
                            await bot.SendTextMessageAsync(message.Chat.Id,
                                "Первое : \n https://metanit.com/sharp/patterns/ \n\n" +
                                "Второе : \n https://refactoring.guru/ru/design-patterns/catalog");
                        }
                        if (message.Text == "Работа с данными (СУБД + NET)")
                        {
                            await bot.SendTextMessageAsync(message.Chat.Id,
                                "Первое : https://professorweb.ru/my/ADO_NET/base/level1/ado_net_index.php\n\n" +
                                "Второе : https://metanit.com/sharp/entityframework/");
                        }

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