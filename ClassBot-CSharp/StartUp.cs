using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassBot_CSharp.Services;
using Sora.Interfaces;
using Sora.Net;
using Sora.OnebotModel;

namespace ClassBot_CSharp
{
    public class StartUp
    {
        public SoraWebsocketClient Client { get; set; }
        public IOptionService OptionService { get; set; }

        public StartUp()
        {
            OptionService = new OptionService();
            
        }

        public void ConfigurationClient()
        {
            var config = OptionService.GetConfig();

            var client = new SoraWebsocketClient(new ClientConfig()
                {
                    Port = config.Port,
                    AccessToken = config.Token
                }
            );

            Client = client;
        }

        public void ConfigurationEvent()
        {
            Client.Event.
        }
    }
}
