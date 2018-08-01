using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    [Table(name: "ManufacturerTables")]
    public class Fabricante
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Nome Fabricante")]
        [Column(name:"Manufacturer")]
        public String NomeFabricante { get; set; }

        [ForeignKey("Empresa")]
        public int? EmpresaId { get; set; }
        public virtual Empresa Empresa { get; set; }

    }
}
