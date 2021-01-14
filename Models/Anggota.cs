using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Perpustakaan.Models
{
    [Table(name: "tm_anggota")]
    public class Anggota
    {
        [Key]
        public int id { get; set; }
        public string kode { get; set; }
        public string nama { get; set; }
        public string notelp { get; set; }
        
    }
}