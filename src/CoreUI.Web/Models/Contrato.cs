using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    [Table(name: "ContractNameTables")]
    public class Contrato
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Código Cliente")]
        [Column(name:"Cod_Cliente")]
        public String CodCliente { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("N˚ Contrato")]
        public String Assigned { get; set; }
    }
}
