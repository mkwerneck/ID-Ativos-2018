using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    [Table(name: "TAGIDPosicaoTables")]
    public class TAGIDPosicao
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Column(name: "TAGID_Posicao")]
        [StringLength(255)]
        [DisplayName("TAGID Posição")]
        public String TAGID { get; set; }

        [Required]
        [Column(name: "Descricao_Posicao")]
        [StringLength(255)]
        [DisplayName("Descrição Posição")]
        public String Descricao { get; set; }

        [ForeignKey("Posicao")]
        public int PosicaoId { get; set; }
        public virtual Posicao Posicao { get; set; }

    }
}
