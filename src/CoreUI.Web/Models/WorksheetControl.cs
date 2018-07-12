using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    [Table(name: "WorksheetControlTables")]
    public class WorksheetControl
    {
        [Required]
        public int Id { get; set; }

        [StringLength(500)]
        public String Observacao { get; set; }

        public String DadosTecnicos { get; set; }

        public DateTime DataHoraUltimaLocalizacao { get; set; }

        public String UltimaLocalizacao { get; set; }

        public String Posicao { get; set; }

        [ForeignKey("Requisicao")]
        public int RequisicaoId { get; set; }
        public virtual Requisicao Requisicao { get; set; }

        [ForeignKey("PurchaseOrder")]
        public int PurchaseOrderId { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }

        [ForeignKey("CertificadoraClassificadora")]
        public int CertificadoraClassificadoraId { get; set; }
        public virtual CertificadoraClassificadora CertificadoraClassificadora { get; set; }

        [Required]
        [ForeignKey("Empresa")]
        public int EmpresaId { get; set; }
        public virtual Empresa Empresa { get; set; }

        [Required]
        [ForeignKey("SetorProprietario")]
        public int SetorProprietarioId { get; set; }
        public virtual SetorProprietario SetorProprietario { get; set; }

        [Required]
        [ForeignKey("CadastroEquipment")]
        public int CadastroEquipmentId { get; set; }
        public virtual CadastroEquipment CadastroEquipment { get; set; }


    }
}
