using Perpustakaan.Models;
using System.Collections.Generic;

namespace Perpustakaan.Data
{
    public interface IBukuRepo
    {
        bool SaveChanges();
        IEnumerable<Buku> GetAllBuku();
        Buku GetBukuById(int id);
        void CreateBuku(Buku model);
        void UpdateBuku(Buku model);
        void DeleteBuku(Buku model);
    }
}