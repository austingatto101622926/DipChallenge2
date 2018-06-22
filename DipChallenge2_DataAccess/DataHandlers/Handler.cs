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
    public class Handler<T>
    {
        HttpClient Client;
        string Controller;
        public Handler(string baseAddress, string controller)
        {
            Client = new HttpClient() { BaseAddress = new Uri(baseAddress) };
            Controller = controller;
        }

        public async Task<List<T>> GET()
        {
            List<T> result = null;
            HttpResponseMessage response = await Client.GetAsync($"/api/{Controller}/");
            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadAsAsync<List<T>>();
            }
            return result;
        }

        public async Task<T> GET(int id)
        {
            T result = default(T);
            HttpResponseMessage response = await Client.GetAsync($"/api/{Controller}/{id}");
            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadAsAsync<T>();
            }
            return result;
        }

        public async void PUT(int id, T @event)
        {
            HttpResponseMessage response = await Client.PutAsJsonAsync<T>($"/api/{Controller}/{id}", @event);
            if (response.IsSuccessStatusCode)
            {
                return;
            }
            else
            {
                throw new Exception();
            }
        }

        public async Task<T> POST(T @event)
        {
            T result = default(T);
            HttpResponseMessage response = await Client.PostAsJsonAsync<T>($"/api/{Controller}/", @event);
            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadAsAsync<T>();
            }
            return result;
        }

        public async Task<T> DELETE(int id)
        {
            T result = default(T);
            HttpResponseMessage response = await Client.DeleteAsync($"/api/{Controller}/{id}");
            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadAsAsync<T>();
            }
            return result;
        }
    }
}
