using System;
using Telegram.Bot;
using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace telegram
{
    public class IventHandler
    {
        public async Task getIventSendLink(TelegramBotClient bot, Update update)
        {
            DataStorage links = new DataStorage();
            try
            {
                var message = update.Message;
                if (message.Text== "Bro button")
                    await bot.SendTextMessageAsync(message.Chat.Id, "DO YOU WANT A HOT BROMANCE??");
                if (message.Text == "Материалы С#")
                    await bot.SendTextMessageAsync(message.Chat.Id, (links.links_c_sharp));
                if (message.Text == "Материалы SQL")
                    await bot.SendTextMessageAsync(message.Chat.Id, (links.links_sql));
                if (message.Text == "Основы Web")
                    await bot.SendTextMessageAsync(message.Chat.Id, (links.links_web));
                if (message.Text== "Паттерны проектирования")
                    await bot.SendTextMessageAsync(message.Chat.Id, links.links_patterns);
                if (message.Text == "Работа с данными (СУБД + NET)")
                    await bot.SendTextMessageAsync(message.Chat.Id,links.links_subd);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("UPSSS IT IS ERROR");
                throw;
            }
            
        }
    }
}