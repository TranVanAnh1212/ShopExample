using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopExample.Model.Abstract
{
    public interface IAuditable
    {
        DateTime CreatedDate { get; set; }

        string CreatedBy { get; set; }

        DateTime? ModifiedDate { get; set; }

        string ModifiedBy { get; set; }

        string MetaKeyWord { get; set; }

        string MetaDescription { get; set; }

        bool Status { get; set; }
    }
}
