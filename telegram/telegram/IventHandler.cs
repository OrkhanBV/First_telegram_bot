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

            var message = update.Message;
                if (message.Text[0] == 'L') ///////////////сделать сигнальный символ после которого будет ввод ссылки!!
                {
                    string str = message.Text;
                    await bot.SendTextMessageAsync(message.Chat.Id, str);
                }
                if (message.Text== "Bro button")
                    await bot.SendTextMessageAsync(message.Chat.Id, "DO YOU WANT A HOT BROMANCE??"); ///Написать usage как добавлять ссылки в БД спец символ тема ссылки сама ссылка! хранение реализовать по типу стека или очереди
                if (message.Text == "Материалы С#")
                    await bot.SendTextMessageAsync(message.Chat.Id, (links.links_part1));
                if (message.Text == "Материалы SQL")
                    await bot.SendTextMessageAsync(message.Chat.Id, (links.links_part2));
                if (message.Text == "Основы Web")
                    await bot.SendTextMessageAsync(message.Chat.Id, (links.links_part3));
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