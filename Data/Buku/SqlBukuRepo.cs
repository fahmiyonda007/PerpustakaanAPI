using System;
using System.Collections.Generic;
using System.Linq;
using Perpustakaan.Models;

namespace Perpustakaan.Data
{
    public class SqlBukuRepo : IBukuRepo
    {
        private readonly PerpustakaanContext _context;

        public SqlBukuRepo(PerpustakaanContext context)
        {
            _context = context;
        }

        public void CreateBuku(Buku model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            _context.Buku.Add(model);
        }

        public void DeleteBuku(Buku model)
        {
           if (model == null)
                throw new ArgumentNullException(nameof(model));

            _context.Buku.Remove(model);
        }

        public IEnumerable<Buku> GetAllBuku()
        {
            return _context.Buku.ToList();
        }

        public Buku GetBukuById(int id)
        {
            return _context.Buku.FirstOrDefault(x => x.id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateBuku(Buku model)
        {
            // throw new NotImplementedException();
        }
    }
}