using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace DipChallenge2_DataAccess
{
    public class EventHandler
    {
        HttpClient Client;
        public EventHandler(string baseAddress)
        {
            Client = new HttpClient() { BaseAddress = new Uri(baseAddress) };
        }
        

    }
}
