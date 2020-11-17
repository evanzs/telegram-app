using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using System.Web.Http;
using System.Web.Http.Results;

using Telegram.Bot.Types.Enums;
using Microsoft.AspNetCore.Mvc;

namespace telegram_app.Controllers
{
    public class TelegramController : ApiController
    {

        public static readonly TelegramBotClient Api = new TelegramBotClient("1182873299:AAGAmzKRcfjMaZH58ai3qzp6a6v6ZJC54KU");


        {"/getdados"}
        public async Task<IHttpActionResult> Post(Update update)
        {
            var message = update.Message;
            Console.WriteLine("Funconou");
          
            if (message.Type == MessageType.Text)
            {
                await Api.SendTextMessageAsync(message.Chat.Id,message.Text);
            }




            return Ok();


        }
       
    }
}