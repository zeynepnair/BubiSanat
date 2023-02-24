using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Bubisanat.Models
{
    public class TopCategory // navbar category
    {
        
        public short Id { get; set; }

        [Column(TypeName = "nchar(50)")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [DisplayName("İsim")]
        [StringLength(50, ErrorMessage = "En fazla 50 karakter olmalıdır.")]
        public string Name { get; set; }

        public List<Category>? Categories{ get; set; }
    }
}
