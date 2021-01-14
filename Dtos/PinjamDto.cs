using System;
using System.ComponentModel.DataAnnotations;

namespace Perpustakaan.Dtos
{
    public class PinjamRead
    {
        public int id { get; set; }
        public int anggota_id { get; set; }
        public int buku_id { get; set; }
        public DateTime tanggal { get; set; }
        public DateTime? tanggal_pengembalian { get; set; }
    }

    public class PinjamCreate
    {
        [Required]
        public int anggota_id { get; set; }
        [Required]
        public int buku_id { get; set; }
        [Required]
        public DateTime tanggal { get; set; }
        public DateTime? tanggal_pengembalian { get; set; }
    }

    public class PinjamUpdate
    {
        [Required]
        public int anggota_id { get; set; }
        [Required]
        public int buku_id { get; set; }
        [Required]
        public DateTime tanggal { get; set; }
        public DateTime? tanggal_pengembalian { get; set; }
    }

    public class PinjamUpdatePengembalian
    {
        public DateTime? tanggal_pengembalian { get; set; }
    }
}