using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gambistWinForm.Models
{
    public class Pari
    {
        public int Id { get; set; }
        public int IdMatch { get; set; }
        public string Email { get; set; }
        public decimal ValeurPari { get; set; }
        public string DatePari { get; set; }
        public decimal TauxVictoire { get; set; }
    }
}
