using Telegram.Bot;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace telegram
{
    public class KeyboardButtons
    {
        public async Task create_buttons(TelegramBotClient bot, Update update)
        {
            var message = update.Message;
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
                    new[] { new KeyboardButton("Паттерны проектирования") },
                    new[] { new KeyboardButton("Bro button")}
                }
            };
            if (message.Text == "/start")
                await bot.SendTextMessageAsync(message.Chat.Id, "Привет Top Bro " + message.Chat.Username,
                    ParseMode.Html, false, false, 0, keybord);
        }
    }
}