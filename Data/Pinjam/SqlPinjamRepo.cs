using System;
using System.Collections.Generic;
using System.Linq;
using Perpustakaan.Models;

namespace Perpustakaan.Data
{
    public class SqlPinjamRepo : IPinjamRepo
    {
        private readonly PerpustakaanContext _context;

        public SqlPinjamRepo(PerpustakaanContext context)
        {
            _context = context;
        }

        public void CreatePinjam(Pinjam model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            _context.Pinjam.Add(model);
        }

        public void DeletePinjam(Pinjam model)
        {
           if (model == null)
                throw new ArgumentNullException(nameof(model));

            _context.Pinjam.Remove(model);
        }

        public IEnumerable<Pinjam> GetAllPinjam()
        {
            return _context.Pinjam.ToList();
        }

        public Pinjam GetPengembalianPinjam(int anggota_id, int buku_id)
        {
            return _context.Pinjam
                .Where(x => x.anggota_id == anggota_id)
                .Where(x => x.buku_id == buku_id)
                .FirstOrDefault();
        }

        public Pinjam GetPinjamById(int id)
        {
            return _context.Pinjam.FirstOrDefault(x => x.id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdatePengembalianPinjam(Pinjam model)
        {
            // throw new NotImplementedException();
        }

        public void UpdatePinjam(Pinjam model)
        {
            // throw new NotImplementedException();
        }
    }
}