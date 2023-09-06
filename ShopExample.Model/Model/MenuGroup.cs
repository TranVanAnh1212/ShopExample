
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopExample.Model.Model
{
    [Table("MenuGroup")]
    public class MenuGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [Required]
        [MaxLength(550)]
        public string Name { get; set; }

        public virtual IEnumerable<Menu> Menu { get; set; }
    }
}
