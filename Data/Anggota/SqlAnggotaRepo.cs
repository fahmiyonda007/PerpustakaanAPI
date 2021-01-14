using System;
using System.Collections.Generic;
using System.Linq;
using Perpustakaan.Models;

namespace Perpustakaan.Data
{
    public class SqlAnggotaRepo : IAnggotaRepo
    {
        private readonly PerpustakaanContext _context;

        public SqlAnggotaRepo(PerpustakaanContext context)
        {
            _context = context;
        }

        public void CreateAnggota(Anggota model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            _context.Anggota.Add(model);
        }

        public void DeleteAnggota(Anggota model)
        {
           if (model == null)
                throw new ArgumentNullException(nameof(model));

            _context.Anggota.Remove(model);
        }

        public IEnumerable<Anggota> GetAllAnggota()
        {
            return _context.Anggota.ToList();
        }

        public Anggota GetAnggotaById(int id)
        {
            return _context.Anggota.FirstOrDefault(x => x.id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateAnggota(Anggota model)
        {
            // throw new NotImplementedException();
        }
    }
}