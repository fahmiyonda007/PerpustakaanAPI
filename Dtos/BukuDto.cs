using System.ComponentModel.DataAnnotations;

namespace Perpustakaan.Dtos
{
    public class BukuRead
    {
        public int id { get; set; }
        public string kode { get; set; }
        public string judul { get; set; }
    }

    public class BukuCreate
    {
        [Required]
        public string kode { get; set; }
        [Required]
        public string judul { get; set; }
    }

    public class BukuUpdate
    {
        [Required]
        public string judul { get; set; }
    }
}