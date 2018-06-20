using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    public class ModeloMateriais
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Column(name: "Modelo_Material")]
        public String Modelo { get; set; }

        [StringLength(255)]
        [DisplayName("ID Omni")]
        [Column(name:"ID_Omni")]
        public String IDOmni { get; set; }

        [StringLength(255)]
        [DisplayName("Part Number")]
        [Column(name:"Part_Number")]
        public String PartNumber { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Descrição Técnica")]
        [Column(name:"Descricao_Tecnica")]
        public String DescricaoTecnica { get; set; }

        [StringLength(255)]
        [DisplayName("Valor Unitário")]
        [Column(name:"Valor_Unitario")]
        public String ValorUnitario { get; set; }

        [Column(name:"Valor_Unitario")]
        public Byte[] Imagem { get; set; }

        [Required]
        public int FabricanteId { get; set; }
        public Fabricante Fabricante { get; set; }

        public int FamiliaId { get; set; }
        public Familia Familia { get; set; }


    }
}
