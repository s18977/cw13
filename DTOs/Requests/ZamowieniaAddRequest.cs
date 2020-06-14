using cw13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw13.DTOs.Requests
{
    public class ZamowieniaAddRequest
    {
        public DateTime DataPrzyjecia { get; set; }
        public string Uwagi { get; set; }
        public ICollection<WyrobRequest> Wyroby { get; set; }

    }
}
