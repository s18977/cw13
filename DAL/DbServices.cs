using cw13.DTOs.Requests;
using cw13.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw13.Services
{
    public class DbServices : ZamowieniaDbService
    {

        private readonly ZamowieniaDbContext _context;

        public DbServices(ZamowieniaDbContext context)
        {
            _context = context;
        }


        public async Task<Zamowienie> AddZamowienia(int id, ZamowieniaAddRequest request)
        {
            var klient = new Klient();
            klient = _context.Klient.Find(id);

            Zamowienie zamowienie = new Zamowienie();
            zamowienie.IdZamowienia = _context.Zamowienie.Count() + 1;

            zamowienie.DataPrzyjecia = request.DataPrzyjecia;
            zamowienie.Uwagi = request.Uwagi;
            zamowienie.IdKlient = klient.IdKlient;

            foreach (WyrobRequest wyrob in request.Wyroby)
            {
                var wyrobCukier = new ZamowienieWyrobCukierniczy();
                var exist = _context.WyrobCukierniczy.Find(wyrob.Wyrób);
                if (exist != null)
                {
                    wyrobCukier.WyrobCukierniczy = exist;
                    wyrobCukier.Zamowienie = zamowienie;
                    wyrobCukier.IdWyrobCukierniczy = exist.IdWyrobCukierniczy;
                    wyrobCukier.Ilosc = wyrob.Ilosc;
                    wyrobCukier.Uwagi = wyrob.Uwagi;
                }
                zamowienie.ZamowienieWyrobyCukiernicze.Add(wyrobCukier);
            }

            return zamowienie;
        }

        public async Task<ICollection<Zamowienie>> GetZamowienia(ZamowieniaRequest request)
        {
            var zamowienia = _context.Klient.Find(request.Nazwisko).zamowienia;

            try
            {
                if (zamowienia.Count == 0)
                {
                    return _context.Zamowienie.ToList();
                }
            }catch (Exception ex)
            {
                return null;
            }

            return zamowienia;
        }
    }
}
