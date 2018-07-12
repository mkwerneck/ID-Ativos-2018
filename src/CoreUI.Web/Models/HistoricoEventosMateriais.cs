using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    [Table(name: "HistoricoEventosMateriaisSet")]
    public class HistoricoEventosMateriais
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public DateTime DataHoraEvento { get; set; }

        [Required]
        public float Quantidade { get; set; }

        [Required]
        public String DominioAtualizacao { get; set; }

        [Required]
        public String Processo { get; set; }

        public String Empresa { get; set; }

        public String Localizacao { get; set; }

        public String Almoxarifado { get; set; }

        public String Posicao { get; set; }

        public String TAGID { get; set; }

        public String ProprietarioSetor { get; set; }

        public String NumeroLote { get; set; }

        public DateTime DataLocalizacaoMobile { get; set; }

        public String CodProcesso { get; set; }

        public String Cautela { get; set; }

        public String DBOS { get; set; }

        public String Mecanico { get; set; }

        [Required]
        [ForeignKey("Posicao")]
        public int PosicaoId { get; set; }
        public virtual Posicao Posicao { get; set; }

        [Required]
        [ForeignKey("CadastroMateriais")]
        public int CadastroMateriaisId { get; set; }
        public virtual CadastroMateriais CadastroMateriais { get; set; }

    }
}
