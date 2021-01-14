using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Perpustakaan.Models
{
    [Table(name: "tt_pinjam")]
    public class Pinjam
    {
        [Key]
        public int id { get; set; }
        public int anggota_id { get; set; }
        public int buku_id { get; set; }
        public DateTime tanggal { get; set; }
        public DateTime? tanggal_pengembalian { get; set; }
    }
}