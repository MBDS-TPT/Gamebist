using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gambistWinForm.Models
{
    public class Match : INotifyPropertyChanged
    {
        public int id { get; set; }
        public int categoryId { get; set; }
        public int teamAId { get; set; }
        public int teamBId { get; set; }
        public string matchDate { get; set; }
        public int state { get; set; }
        public string EtatImport { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
