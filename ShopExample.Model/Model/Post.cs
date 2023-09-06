using ShopExample.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopExample.Model.Model
{
    [Table("Posts")]
    public class Post : Auditable
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
        public virtual PostCategory PostCategory { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(256)]
        public string Image { get; set; }

        public bool HomeFlag { get; set; }

        public bool HotFlag { get; set; }

        public int ViewCount { get; set; }


    }
}
