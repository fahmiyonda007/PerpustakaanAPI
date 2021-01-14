using Perpustakaan.Models;
using System.Collections.Generic;

namespace Perpustakaan.Data
{
    public interface IAnggotaRepo
    {
        bool SaveChanges();
        IEnumerable<Anggota> GetAllAnggota();
        Anggota GetAnggotaById(int id);
        void CreateAnggota(Anggota model);
        void UpdateAnggota(Anggota model);
        void DeleteAnggota(Anggota model);
    }
}