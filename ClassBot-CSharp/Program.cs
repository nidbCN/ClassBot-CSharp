using System;
using System.Threading.Tasks;

using Sora.Net;
using Sora.OnebotModel;

using YukariToolBox.Extensions;
using YukariToolBox.FormatLog;


namespace ClassBot_CSharp
{
    class Program
    {
        private static async Task Main(string[] args)
        {
            service.Event.OnGroupMessage += async (msgType, eventArgs) =>
            {
                if (eventArgs.Message.RawText == "test")
                {
                    await eventArgs.Repeat();
                }
                
            };

            await service.StartService()
                .RunCatch(e => 
                    Log.Error("Sora Service", Log.ErrorLogBuilder(e))
                );

            await Task.Delay(-1);

            Console.WriteLine("Hello World!");
        }
    }
}
