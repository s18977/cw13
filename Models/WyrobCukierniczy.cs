using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw13.Models
{
    public class WyrobCukierniczy
    {
        public int IdWyrobCukierniczy { get; set; }
        public string Nazwa { get; set; }
        public float CenaZaSzt { get; set; }
        public string Typ { get; set; }

        public virtual ICollection<ZamowienieWyrobCukierniczy> ZamowienieWyrobyCukiernicze { get; set; }
    }
}
