using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopExample.Model.Model
{
    [Table("SystemConfigs")]
    public class SystemConfig
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [Required]
        public int Code { get; set; }

        [MaxLength(500)]
        public string ValueStr { get; set; }

        public int ValueInt { get; set; }
    }
}
