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
    [Table("Orders")]
    public class Order : Auditable
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [Required]
        [MaxLength(501)]
        public string CustomerName { get; set; }

        [Required]
        [MaxLength(501)]
        public string CustomerAddress { get; set; }

        [Required]
        [MaxLength(20)]
        public string CustomerPhone { get; set; }

        [MaxLength(501)]
        public string CustomerEmail { get; set; }

        [MaxLength(501)]
        public string CustomerMessage { get; set; }

        [Required]
        [MaxLength(256)]
        public string PaymentMethod { get; set; }

        [MaxLength(256)]
        public string PaymentStatus { get; set; }


    }
}
