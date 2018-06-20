using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    [Table(name: "SetorProprietarios")]
    public class SetorProprietario
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Descrição Setor")]
        public String Descricao { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Gestor Responsável")]
        public String Gestor { get; set; }

        [Required]
        [ForeignKey("Empresa")]
        public int EmpresaId { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}
