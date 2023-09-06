using ShopExample.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ShopExample.Model.Model
{
    [Table("Products")]
    public class Product : Auditable
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

        public string Contents { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(500)]
        public string Alias { get; set; }

        public long CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(256)]
        public string Image { get; set; }

        public XElement MoreImage { get; set; }

        public bool HomeFlag { get; set; }

        public bool HotFlag { get; set; }

        public int ViewCount { get; set; }

        public int BuyCount { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal PromotionPrice { get; set; }

        public int Warranty { get; set; } // Bảo hành - theo tháng

        public int ReviewCount { get; set; }

        [MaxLength(500)]
        public string Origin { get; set; }
    }
}
