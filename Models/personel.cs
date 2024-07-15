using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace proje.Models
{
    public class personel
    {
        [Key]
        public int perid { get; set; }
        [Column(TypeName = "VARCHAR(5)")]
        [StringLength(30)]
        public string ad { set; get; }
        [Column(TypeName = "VARCHAR(30)")]
        [StringLength(30)]
        public string soyad { set; get; }
        [Column(TypeName = "VARCHAR(30)")]
        [StringLength(50)]
        public string sehir { set; get; }

        public int departid { get; set; }

        public departmanlar depart { get; set; }

    }
}
