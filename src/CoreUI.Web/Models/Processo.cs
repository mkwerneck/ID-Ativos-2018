using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    [Table(name: "ProcessoEqReadinessTables")]
    public class Processo
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int CodProcesso { get; set; }

        [Required]
        public String Status { get; set; }

        public String StatusProcessoUsuario { get; set; }

        [Required]
        public DateTime DataInicio { get; set; }

        public DateTime DataPrevisaoInicial { get; set; }

        public DateTime DataPrevisaoAtual { get; set; }

        public DateTime DataConclusao { get; set; }

        public DateTime DataCancelado { get; set; }

        public String ProprietarioSetor { get; set; }

        public String TraceNumber { get; set; }

        public String EquipmentType { get; set; }

        public String DataPrevisaoConclusaoMobile { get; set; }

        public int PrioridadeExecucao { get; set; }

        public String NumCautela { get; set; }

        public String Mecanico { get; set; }

        public String OSDB { get; set; }

        public String Dominio { get; set; }

        public String Ferramenteiro { get; set; }

        [ForeignKey("PurchaseOrder")]
        public int PurchaseOrderId { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }

        [ForeignKey("Requisicao")]
        public int RequisicaoId { get; set; }
        public virtual Requisicao Requisicao { get; set; }

        [ForeignKey("Posicao")]
        public int PosicaoId { get; set; }
        public virtual Posicao Posicao { get; set; }

        [Required]
        [ForeignKey("WorksheetControl")]
        public int WorksheetControlId { get; set; }
        public virtual WorksheetControl WorksheetControl { get; set; }

        [Required]
        [ForeignKey("SetorProprietario")]
        public int SetorProprietarioId { get; set; }
        public virtual SetorProprietario SetorProprietario { get; set; }
    }
}
