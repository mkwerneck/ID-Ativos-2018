using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    [Table(name: "ModalidadeEmpresaTables")]
    public class Modalidade
    {
        [Required]
        public int Id { get; set; }

        [Required][StringLength(255)][DisplayName("Descrição")]
        [Column(name:"Modalidade")]
        public String Descricao { get; set; }
    }
}
