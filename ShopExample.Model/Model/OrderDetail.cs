
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopExample.Model.Model
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        [Required]
        public long OrderID { get; set; }

        [Key]
        [Required]
        public long ProductID { get; set; }

        [Required]
        public int Quantity { get; set; }

        [ForeignKey("OrderID")]
        public virtual Order Order { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
    }
}
