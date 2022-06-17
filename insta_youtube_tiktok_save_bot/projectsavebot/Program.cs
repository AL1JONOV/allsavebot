using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace allsavebot
{
    class Program
    {
        private static string token = "5589132832:AAFDZlIuIAteCUFNDaTeweCyu62A3ApYVxM";
        private static TelegramBotClient client;

        static void Main(string[] args)
        {
            client = new TelegramBotClient(token);
            client.StartReceiving();
            client.OnMessage += OnMessageHandler;
            Console.ReadLine();
            client.StopReceiving();
            //Console.WriteLine("Assalomu Alaykum : Hi every one: ");

        }

        private static async void OnMessageHandler(object? sender, MessageEventArgs e)
        {

            var message = e.Message;
            if (message.Text != null)
            {
                Console.WriteLine($"Salom => {message.Text}");
                await client.SendTextMessageAsync(
                    message.Chat.Id,
                    message.Text
                   // replyToMessageId: message.MessageId
                    );
            }
        }


    }
}