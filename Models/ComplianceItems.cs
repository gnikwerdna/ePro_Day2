using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ePro.Models
{
    public class ComplianceItems
    {

        [Key]
        public int ComplianceItemsID { get; set; }
         [Display(Name = "Item Name")]
        public string ItemName { get; set; }
         [Display(Name = "End Item")]
        public bool EndItem { get; set; }
        public virtual ICollection<Compliance> Compliance { get; set; }
    }
}