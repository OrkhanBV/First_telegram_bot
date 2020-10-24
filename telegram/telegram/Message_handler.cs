using System;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using System.Threading.Tasks;

/*
 * System.Threading.Tasks
 *
 * Task тип возвращаемого значения при асинхронном программировани более подробно см по ссылке
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

        public static async Task GetMessages()
        {
            TelegramBotClient bot = new TelegramBotClient(TOKEN);
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
                            Console.WriteLine("Получено сообщение:" + message.Text);
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
                                    new[]
                                    {
                                        new KeyboardButton("Работа с данными (СУБД + NET)")
                                    },
                                    new[]
                                    {
                                        new KeyboardButton("Паттерны проектирования")
                                    },
                                    new[]
                                    {
                                        new KeyboardButton("Bro button")
                                    }
                                }
                            };
                            await bot.SendTextMessageAsync(message.Chat.Id, "Привет Bro" + message.Chat.Username,
                                ParseMode.Html, false, false, 0, keybord);
                        }

                        if (message.Text == "Bro button")
                        {
                            await bot.SendTextMessageAsync(message.Chat.Id, "We have a BROMANCE?????" +
                                                                            "YYYeeeeeess that's right we hawe a BROMANCE");
                            Console.WriteLine("Получено сообщение:" + message.Text); //Попробуем декоратор замутить
                        }

                        if (message.Text == "Материалы С#")
                        {
                            await bot.SendTextMessageAsync(message.Chat.Id,
                                "Первое : Metanit \n https://metanit.com/sharp/tutorial/ \n" +
                                "Второе : Professorweb \n https://professorweb.ru/my/csharp/charp_theory/level1/index.php");
                            Console.WriteLine("Получено сообщение:" + message.Text);
                        }

                        if (message.Text == "Материалы SQL")
                        {
                            await bot.SendTextMessageAsync(message.Chat.Id,
                                "Первое : Metanit \n https://metanit.com/sql/sqlserver/ \n\n" +
                                "Второе : Professorweb \n https://professorweb.ru/my/sql-server/2012/level1/ \n\n" +
                                "Третье : YouTube \n https://youtu.be/jb_gkVQqikA");
                        }

                        if (message.Text == "Основы Web")
                        {
                            await bot.SendTextMessageAsync(message.Chat.Id,
                                "Первое : Вводдная часть \n1)  https://www.youtube.com/watch?v=tiRIWEnvsPI \n" +
                                "2)  https://youtu.be/E0t2CYo0qSk \n" +
                                "3)  https://youtu.be/PsLzEAsphbM \n\n\n" +
                                "Второе : Модель OSI \n1)  https://youtu.be/i16XviL8YMY \n" +
                                "2)  https://professorweb.ru/my/csharp/web/level1/1_2.php\n\n\n" +
                                "Третье : Основы ASP.NET приложений \n1)  https://metanit.com/sharp/aspnet_webapi/ \n" +
                                "2)  https://docs.microsoft.com/ru-ru/aspnet/web-api/overview/getting-started-with-aspnet-web-api/tutorial-your-first-web-api \n\n" +
                                "Дополнительно : \n" +
                                "1)  https://metanit.com/sharp/articles/mvc/13.php \n" +
                                "2)  https://metanit.com/sharp/articles/mvc/10.php \n" +
                                "3)  https://habr.com/ru/post/189086/ \n\n\n" +
                                "Четвертое : \n" +
                                "COMET: WebSockets, LongPooling, Server Sent Events SignalR \n" +
                                "1)  https://metanit.com/sharp/mvc5/16.1.php \n" +
                                "2)  https://docs.microsoft.com/ru-ru/aspnet/signalr/overview/getting-started/introduction-to-signalr \n\n\n" +
                                "Пятое : OWIN и Katana \n" +
                                "1)  https://metanit.com/sharp/mvc5/11.1.php\n" +
                                "2)  https://andrey.moveax.ru/post/owin-introduction-part1\n" +
                                "3)  https://habr.com/ru/post/202018/\n"
                            );
                        }

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