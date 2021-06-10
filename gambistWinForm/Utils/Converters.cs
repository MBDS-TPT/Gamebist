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
    }
}
