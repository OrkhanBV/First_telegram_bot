using System;
using Telegram.Bot;
using System.Threading.Tasks;
using Telegram.Bot.Types;

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
    public class IventHandler
    {
        public async Task getIventSendLink(TelegramBotClient bot, Update update)
        {
            DataStorage links = new DataStorage();

                var message = update.Message;
                if (message.Text[0] == 'L') ///////////////сделать сигнальный символ после которого будет ввод ссылки!!
                {
                    string str = message.Text;
                    await bot.SendTextMessageAsync(message.Chat.Id, str);
                }
                if (message.Text== "Bro button")
                    await bot.SendTextMessageAsync(message.Chat.Id,
                        "DO YOU WANT A HOT BROMANCE?? BROKHANBOT WANT IT!!!"); ///Написать usage как добавлять ссылки в БД спец символ тема ссылки сама ссылка! хранение реализовать по типу стека или очереди
                if (message.Text == "Материалы С#")
                    await bot.SendTextMessageAsync(message.Chat.Id, (links.link1 + links.link2));
                if (message.Text == "Материалы SQL")
                    await bot.SendTextMessageAsync(message.Chat.Id, (links.link3 + links.link4 + links.link5));
                if (message.Text == "Основы Web")
                    await bot.SendTextMessageAsync(message.Chat.Id, (links.link6 + links.link7 + links.link8
                    + links.link9 + links.link10 + links.link11 + links.link12
                    + links.link13 + links.link14 + links.link15 + links.link16
                    + links.link17 + links.link18 + links.link19 + links.link20
                    + links.link21 + links.link22 + links.link23 + links.link24));
                if (message.Text== "Паттерны проектирования")
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
        }
    }
}


namespace telegram
{
    public class BroKhanBot
    {
            private const string TOKEN = "1307823169:AAEhyMxnJXAnQJWONwCg2keQFbAW2-j4NTA";
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