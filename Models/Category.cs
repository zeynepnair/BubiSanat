using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bubisanat.Models
{
    public class Category
    {
        
        public short Id { get; set; }

        [Column(TypeName="nchar(50)")]
        [Required(ErrorMessage ="Bu alan zorunludur.")]
        [DisplayName("İsim")]
        [StringLength(50,ErrorMessage ="En fazla 50 karakter olmalıdır.")]
        public string Name { get; set; }

        [Column(TypeName = "nchar(100)")]
        [DisplayName("Bilgi")]
        [StringLength(100, ErrorMessage = "En fazla 100 karakter olmalıdır.")]
        public string? Info { get; set; }

        [DisplayName("Ana Kategori (opsiyonel)")]
        public short? TopCategoryId { get; set; }

        [DisplayName("Ana Kategori")]
        [ForeignKey(nameof(TopCategoryId))]
        public TopCategory? TopCategory { get; set; }
    }
}
