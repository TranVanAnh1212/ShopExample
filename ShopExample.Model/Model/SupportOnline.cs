using ShopExample.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopExample.Model.Model
{
    [Table("SupportOnlines")]
    public class SupportOnline : Auditable
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [MaxLength(255)]
        public string Department { get; set; }

        [MaxLength(255)]
        public string Skype { get; set; }

        [MaxLength(20)]
        public string Mobile { get; set; }

        [MaxLength(255)]
        public string Email { get; set; }

        [MaxLength(255)]
        public string Facebook { get; set; }

        [MaxLength(255)]
        public string Twitter { get; set; }

        [MaxLength(255)]
        public string Instagram { get; set; }
    }
}
