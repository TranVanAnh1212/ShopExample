
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopExample.Model.Model
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [Required]
        [MaxLength(501)]
        public string Name { get; set; }

        [Required]
        [MaxLength(256)]
        [Column(TypeName = "varchar")]
        public string Url { get; set; }

        public int DisplayOrder { get; set; }

        public long GroupID { get; set; }
        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(10)]
        public string Target { get; set; }

        [Required]
        public bool Static { get; set; }
    }
}
