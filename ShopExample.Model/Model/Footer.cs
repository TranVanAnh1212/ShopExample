
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopExample.Model.Model
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        [MaxLength(50)]
        public string ID { get; set; }

        [Required]
        [MaxLength(550)]
        public string Name { get; set; }

        [MaxLength(550)]
        public string Contents { get; set; }
    }
}
