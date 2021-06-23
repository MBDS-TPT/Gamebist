using gambistWinForm.Models;
using gambistWinForm.Utils;
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
    public class PariServices
    {
        static HttpClient client = new HttpClient();

        static PariServices()
        {
            client.BaseAddress = new Uri("http://localhost:8080/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public List<Pari> GetListPari(string dateFormat)
        {
            try
            {
                var result = new List<Pari>();
                var response = client.GetAsync("bet/byDate?date=" + dateFormat).Result;

                if (response.IsSuccessStatusCode)
                {
                    var dataObjects = response.Content.ReadAsAsync<List<JObject>>().Result;
                    foreach (var obj in dataObjects)
                    {
                        result.Add(Converters.JObjectToPari(obj));
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
