using gambistWinForm.Models;
using gambistWinForm.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

        public List<Configuration> GetListConfig() 
        {
            try
            {
                var result = new List<Configuration>();
                var response = client.GetAsync("configurations").Result;

                if (response.IsSuccessStatusCode)
                {
                    var dataObjects = response.Content.ReadAsAsync<List<JObject>>().Result;
                    foreach (var obj in dataObjects) 
                    {
                        result.Add(Converters.JObjectToConfiguration(obj));
                    }
                    return result;
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
                var configuration = new Configuration() { ConfigKey = configKey, ConfigValue = configValue };
                var response = await client.PostAsJsonAsync("configurations", configuration);
                return true;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
            
        }

        public async Task<bool> UpdateConfigAsync(Configuration conf)
        {
            try
            {
                var jsonString = JsonConvert.SerializeObject(conf);
                HttpContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                var response = await client.PutAsync("configurations/" + conf.Id, content);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> DeleteConfigAsync(Configuration conf)
        {
            try
            {
                var response = await client.DeleteAsync("configurations/" + conf.Id);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Configuration> SearchConfigAsync(string confKey)
        {
            try
            {
                var result = new List<Configuration>();
                HttpResponseMessage response = null;

                if (string.IsNullOrEmpty(confKey)) 
                {
                    response = client.GetAsync("configurations").Result;
                }
                else 
                {
                    response = client.GetAsync("configurations/keyname/" + confKey).Result;
                }

                if (response.IsSuccessStatusCode)
                {
                    var dataObjects = response.Content.ReadAsAsync<List<JObject>>().Result;
                    foreach (var obj in dataObjects)
                    {
                        result.Add(Converters.JObjectToConfiguration(obj));
                    }
                    return result;
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
    }
}
