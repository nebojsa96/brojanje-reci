using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BrojanjeReciConsoleApp.Services
{
    class TextRestService
    {
        static HttpClient client = new HttpClient();


        public static async Task<int> CountWordsAsync(string text)
        {
            client.BaseAddress = new Uri(AppSettings.API_SERVER_URL);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            TextDTO textDTO = new TextDTO { Text = text};
            
            HttpResponseMessage response = await client.PostAsJsonAsync($"text/CountWords", textDTO);
     

            int result = -1;
            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadAsAsync<int>();
            }

            return result;
        }
    }


}
