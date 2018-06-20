using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    [Table(name: "TAGID_EquipmentTables")]
    public class TAGIDEquipment
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Column(name:"TAGID_Equipment")]
        public String TAGID { get; set; }
    }
}
