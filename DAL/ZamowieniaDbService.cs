using cw13.DTOs.Requests;
using cw13.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw13.Services
{
    public interface ZamowieniaDbService
    {
        public Task<ICollection<Zamowienie>> GetZamowienia(ZamowieniaRequest request);
        public Task<Zamowienie> AddZamowienia(int id, ZamowieniaAddRequest request);
    }
}
