using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    [Table(name: "Servicos_AdicionaisSet")]
    public class ServicoAdicional
    {
        [Required]
        public int Id { get; set; }

        [Required] [StringLength(255)] [DisplayName("Serviço")]
        [Column(name: "Servico_Adicional")]
        public String Servico { get; set; }

        [StringLength(255)] [DisplayName("Descrição")]
        public String Descricao { get; set; }

        [RegularExpression(@"^\d+\.\d{0,2}$")] [Range(0, 9999999999999999.99)]
        public Decimal Valor { get; set; }

        [Required] [StringLength(255)]
        [Column(name:"Modalidade_Servico")]
        public String Modalidade { get; set; }

        [DisplayName("Tornar Obrigatório")]
        public Boolean FlagObrigatorio { get; set; }

        [DisplayName("Ativar Serviço")]
        public Boolean FlagAtivo { get; set; }

        [Required]
        public int CategoriaServicosAdicionaisId { get; set; }
        public virtual CategoriaServicosAdicionais GetCategoriaServicosAdicionais { get; set; }

        [Required]
        public int TarefaId { get; set; }
        public virtual Tarefa Tarefa { get; set; }
    }
}
