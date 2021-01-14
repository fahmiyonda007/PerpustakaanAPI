using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Perpustakaan.Models
{
    [Table(name: "tm_buku")]
    public class Buku
    {
        [Key]
        public int id { get; set; }
        public string kode { get; set; }
        public string judul { get; set; }
    }
}