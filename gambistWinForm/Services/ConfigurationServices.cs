using gambistWinForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace gambistWinForm.Services
{
    public class ConfigurationServices
    {
        static HttpClient client = new HttpClient();

        static ConfigurationServices() 
        {
            client.BaseAddress = new Uri("http://localhost:8010/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public bool GetListConfigAsync() 
        {
            try
            {
                var response = client.GetAsync("configurations").Result;

                if (response.IsSuccessStatusCode)
                {
                    var dataObjects = response.Content.ReadAsAsync<List<object>>().Result;
                    return true;
                }
                else
                {
                    throw new Exception(response.StatusCode.ToString());
                }
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public async Task<bool> AddConfigAsync(string configKey, string configValue)
        {
            try
            {
                var product = new Configuration() { ConfigKey = configKey, ConfigValue = configValue };
                var response = await client.PostAsJsonAsync("configurations", product);
                return true;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
            
        }
    }
}
