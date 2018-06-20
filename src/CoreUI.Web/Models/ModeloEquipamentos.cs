using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    [Table(name: "EquipmentTypeTables")]
    public class ModeloEquipamentos
    {
        public int Id { get; set; }

        [Required]
        [StringLength(600)]
        [DisplayName("Equipment_Type")]
        public String Modelo { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Descrição Técnica")]
        [Column(name:"Descricao_Tecnica")]
        public String DescricaoTecnica { get; set; }

        [Column(name:"ImagemAtivo")]
        public String Imagem { get; set; }

        [StringLength(255)]
        [DisplayName("Part Number")]
        [Column(name:"Part_Number")]
        public String PartNumber { get; set; }

        [Required]
        public int FabricanteId { get; set; }
        public virtual Fabricante Fabricante { get; set; }

        [Required]
        public int CategoriaEquipamentosId { get; set; }
        public virtual CategoriaEquipamentos GetCategoriaEquipamentos { get; set; }
    }
}
