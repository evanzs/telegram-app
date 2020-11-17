using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin.Hosting;
using Owin;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace telegram_app
{
    public class Program
    {
        public static readonly TelegramBotClient Api = new TelegramBotClient("1182873299:AAGAmzKRcfjMaZH58ai3qzp6a6v6ZJC54KU");
        public static void Main()
        {

            var me = Api.GetMeAsync().Result;
            Console.WriteLine(me.Id);
            //using (WebApp.Start<Startup>("https://+:443"))
            //{
            //    Api.SetWebhookAsync("https://web.telegram.org/#/im?p=@evanzs_bot:443/WebHook").Wait();
            //    Console.WriteLine("servidor iniciou");

            //}

        }
    }
}