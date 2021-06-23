using gambistWinForm.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gambistWinForm.Utils
{
    public static class Converters
    {
        public static Configuration JObjectToConfiguration(JObject obj) 
        {
            return new Configuration()
            {
                Id = obj["_id"].ToString(),
                ConfigKey = obj["configkey"].ToString(),
                ConfigValue = obj["configvalue"].ToString()
            };
        }

        public static Pari JObjectToPari(JObject obj)
        {
            var match = obj["match"];
            var user = obj["user"];

            return new Pari()
            {
                Id = int.Parse(obj["id"].ToString()),
                DatePari = obj["betDate"].ToString(),
                TauxVictoire = decimal.Parse(obj["winningRate"].ToString()),
                ValeurPari = decimal.Parse(obj["betValue"].ToString()),
                Email = user["email"].ToString(),
                IdMatch = int.Parse(match["id"].ToString())
            };
        }
    }
}
