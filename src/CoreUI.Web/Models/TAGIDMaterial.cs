using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    [Table(name: "TAGID_MateriaisTables")]
    public class TAGIDMaterial
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Column(name:"TAGID_Material")]
        public String TAGID { get; set; }
    }
}
