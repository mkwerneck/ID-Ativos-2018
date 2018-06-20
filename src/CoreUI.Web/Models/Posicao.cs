using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    [Table(name: "PosicaoTables")]
    public class Posicao
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Column(name: "Cod_Posicao")]
        [StringLength(255)]
        [DisplayName("Código Posição")]
        public String Codigo { get; set; }

        [Required]
        [Column(name: "Desc_Posicao")]
        [StringLength(255)]
        [DisplayName("Descrição Posição")]
        public String Descricao { get; set; }

        [Required]
        [ForeignKey("Almoxarifado")]
        public int AlmoxarifadoId { get; set; }
        public virtual Almoxarifado Almoxarifado { get; set; }
    }
}
