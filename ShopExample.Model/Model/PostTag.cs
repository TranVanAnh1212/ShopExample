
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopExample.Model.Model
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        public long PostID { get; set; }

        [Key]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string TagID { get; set; }

        [ForeignKey("PostID")]
        public virtual Post Post { get; set; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { get; set; }
    }
}
