using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopExample.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime CreatedDate { get; set; }

        [MaxLength(500)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [MaxLength(500)]
        [Column(TypeName = "varchar")]
        public string ModifiedBy { get; set; }

        [MaxLength(256)]
        [Column(TypeName = "varchar")]
        public string MetaKeyWord { get; set; }

        [MaxLength(256)]
        public string MetaDescription { get; set; }

        public bool Status { get; set; }
    }
}
