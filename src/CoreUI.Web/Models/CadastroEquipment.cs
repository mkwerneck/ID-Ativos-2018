using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    [Table(name: "CadastrosEquipmentTable")]
    public class CadastroEquipment
    {
        [Required]
        public int id { get; set; }

        [Required]
        public String TraceNumber { get; set; }

        public DateTime DataFabricacao { get; set; }

        public String NumContrato { get; set; }

        public String Condicao { get; set; }

        public String ESN { get; set; }

        public String TAGID { get; set; }

        public String Capacidade { get; set; }

        public Byte[] Imagem { get; set; }

        public String StatusMateriais { get; set; }

        public String Status { get; set; }

        [ForeignKey("ModeloEquipamentos")]
        public int ModeloEquipamentosId { get; set; }
        public virtual ModeloEquipamentos ModeloEquipamentos { get; set; }

        [ForeignKey("Fabricante")]
        public int FabricanteId { get; set; }
        public virtual Fabricante Fabricante { get; set; }

        [ForeignKey("Localizacao")]
        public int LocalizacaoId { get; set; }
        public virtual Localizacao Localizacao { get; set; }

        [ForeignKey("CategoriaEquipamentos")]
        public int CategoriaEquipamentosId { get; set; }
        public virtual CategoriaEquipamentos CategoriaEquipamentos { get; set; }
    }
}
