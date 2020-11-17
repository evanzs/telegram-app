using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin.Hosting;
using Owin;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using File = System.IO.File;
namespace Telegram.Bot.Examples.DotNetCoreWebHook{
    public class Startup
    {

        public void Configuration(IAppBuilder app)
        {
            var configuration = new HttpConfiguration();

            configuration.Routes.MapHttpRoute("WebHook", "Telegramcontroller");

            app.Use(configuration);
        }
    }
}