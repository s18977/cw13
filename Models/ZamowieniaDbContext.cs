using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw13.Models
{
    public class ZamowieniaDbContext : DbContext
    {
        public DbSet<Klient> Klient { get; set; }
        public DbSet<Pracownik> Pracownik { get; set; }
        public DbSet<WyrobCukierniczy> WyrobCukierniczy { get; set; }
        public DbSet<Zamowienie> Zamowienie { get; set; }
        public DbSet<ZamowienieWyrobCukierniczy> ZamowienieWyrobCukierniczy { get; set; }

        public ZamowieniaDbContext() { }
        public ZamowieniaDbContext(DbContextOptions options) : base(options) { }
    }
}
