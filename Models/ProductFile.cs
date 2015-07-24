using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ePro.Models
{
    public class ProductFile
    {
     [Key]
     public int ProductFileID { get; set; }
     [Required(ErrorMessage = "{0} is required")]
     [Display(Name = "Description")]
     public string Description { get; set; }
     public int ProductListingID { get; set; }
     public virtual Product Product { get; set; }
    


    }
}