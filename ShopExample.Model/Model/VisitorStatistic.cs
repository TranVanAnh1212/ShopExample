using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopExample.Model.Model
{
    [Table("VisitorStatistic")]
    public class VisitorStatistic
    {
        [Key]
        [Required]
        public Guid ID { get; set; }

        [Required]
        public DateTime VisitedDate { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string IPAddress { get; set; }
    }
}
