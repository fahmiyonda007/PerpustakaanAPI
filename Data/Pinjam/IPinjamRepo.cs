using Perpustakaan.Models;
using System.Collections.Generic;

namespace Perpustakaan.Data
{
    public interface IPinjamRepo
    {
        bool SaveChanges();
        IEnumerable<Pinjam> GetAllPinjam();
        Pinjam GetPinjamById(int id);
        void CreatePinjam(Pinjam model);
        void UpdatePinjam(Pinjam model);
        void DeletePinjam(Pinjam model);
        Pinjam GetPengembalianPinjam(int anggota_id, int buku_id);
        void UpdatePengembalianPinjam(Pinjam model);
    }
}