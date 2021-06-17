using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gambistWinForm.Models
{
    public class Match
    {
        public int Id { get; set; }
        public int IdCategory { get; set; }
        public int TeamA { get; set; }
        public int TeamB { get; set; }
        public DateTime MatchDate { get; set; }
        public int State { get; set; }
    }
}
