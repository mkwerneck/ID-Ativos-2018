using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    [Table(name: "PurchaseOrderTables")]
    public class PurchaseOrder
    {
        [Required]
        public int Id { get; set; }

        [Required][StringLength(255)]
        public String PO { get; set; }
    }
}
