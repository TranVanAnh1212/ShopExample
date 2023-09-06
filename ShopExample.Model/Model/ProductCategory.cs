using ShopExample.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopExample.Model.Model
{
    [Table("ProductCategories")]
    public class ProductCategory : Auditable
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [Required]
        [MaxLength(501)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(500)]
        public string Alias { get; set; }

        public int ParentID { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(256)]
        public string Image { get; set; }

        public int DisplayOrder { get; set; }

        public bool HomeFlag { get; set; }
    }
}
