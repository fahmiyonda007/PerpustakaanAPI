using System.ComponentModel.DataAnnotations;

namespace Perpustakaan.Dtos
{
    public class AnggotaRead
    {
        public int id { get; set; }
        public string kode { get; set; }
        public string nama { get; set; }
        public string notelp { get; set; }
    }

    public class AnggotaCreate
    {
        [Required]
        public string kode { get; set; }
        [Required]
        public string nama { get; set; }
        [Required]
        public string notelp { get; set; }
    }

    public class AnggotaUpdate
    {
        [Required]
        public string nama { get; set; }
        [Required]
        public string notelp { get; set; }
    }
}