using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    [Table(name: "Familias")]
    public class Familia
    {
        [Required]
        public int Id { get; set; }

        [StringLength(255)] [DisplayName("Nome Família")]
        public String NomeFamilia { get; set; }

        [StringLength(255)][DisplayName("Descrição")][Column(name: "DescricaoFamilia")]
        public String Descricao { get; set; }
    }
}
