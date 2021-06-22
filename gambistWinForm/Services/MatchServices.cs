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
    public class MatchServices
    {
        static HttpClient client = new HttpClient();

        static MatchServices()
        {
            client.BaseAddress = new Uri("http://localhost:8080/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public bool AddMatchAsync(Match match)
        {
            try
            {
                Task<HttpResponseMessage> addState  = client.PostAsJsonAsync("match/add", match);
                addState.Wait();

                if (addState.Result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
