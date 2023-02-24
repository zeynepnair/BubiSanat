using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Bubisanat.Models
{
    public class Post
    {
        public long Id { get; set; }

        [Column(TypeName = "nchar(50)")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [DisplayName("Başlık")]
        [StringLength(50, ErrorMessage = "En fazla 50 karakter olmalıdır.")]
        public string Title { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CreatedAt { get; set; }

        public bool Deleted{ get; set; }

        [DisplayName("Yazar")]
        public string AuthorId { get; set; }

        [DisplayName("Kategori")]
        public short CatagoryId { get; set; }

        [ForeignKey("CatagoryId")]
        [DisplayName("Kategori")]
        public Category? Category { get; set; }

        [Column(TypeName = "ntext")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [DisplayName("İçerik")]
        public string Content { get; set; }


        public long Likes { get; set; }
        public long DisplayCount { get; set; }

        [Column(TypeName = "nchar(100)")]
        [DisplayName("Etiketler")]
        [StringLength(100, ErrorMessage = "En fazla 100 karakter olmalıdır.")]
        public string? Tags { get; set; }


        [DisplayName("Önceki İçerik")]
        public long? PreviousPostId { get; set; }

        public long? NextPostId { get; set; }

        [ForeignKey("PreviousPostId")]
        [DisplayName("Önceki içerik")]
        public Post? PreviousPost { get; set; }

        [ForeignKey("NextPostId")]
        public Post? NextPost { get; set; }

        [DisplayName("Yazar")]
        [ForeignKey("AuthorId")]
        public ApplicationUser? Author { get; set; }

        [NotMapped]
        [DisplayName("Görsel")]
        public IFormFile? FormImage { get; set; }

        [Column(TypeName="image")]
        public byte[]? Image { get; set; }
    }
}
