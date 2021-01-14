using Microsoft.EntityFrameworkCore;
using Perpustakaan.Models;

namespace Perpustakaan.Data
{
    public class PerpustakaanContext : DbContext
    {
        public PerpustakaanContext(DbContextOptions<PerpustakaanContext> opt) : base(opt)
        {
            
        }

        public DbSet<Anggota> Anggota { get; set; }
        public DbSet<Buku> Buku { get; set; }
        public DbSet<Pinjam> Pinjam { get; set; }
    }
}