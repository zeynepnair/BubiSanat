using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Bubisanat.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Column(TypeName = "nchar(100)")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [DisplayName("İsim")]
        [StringLength(100, MinimumLength =5, ErrorMessage = "En az 5, en fazla 100 karakter olmalıdır.")]
        public string Name { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [DisplayName("Şifre")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "En az 8, en fazla 100 karakter olmalıdır.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [DisplayName("Şifre(tekrar)*")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "En az 8, en fazla 100 karakter olmalıdır.")]
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        public bool Deleted { get; set; }

        [NotMapped]
        [DisplayName("Üyelik sözleşmesini kabul ediyorum.")]
        public bool Agreed { get; set; }

        [EmailAddress]
        public override string Email { get; set; }
    }
}
