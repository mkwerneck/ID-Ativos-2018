using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    [Table(name: "AlmoxarifadoTables")]
    public class Almoxarifado
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Column(name: "Cod_Almoxarifado")]
        [StringLength(255)]
        [DisplayName("Código Almoxarifado")]
        public String Codigo { get; set; }

        [Required]
        [Column(name: "Nome_Almoxarifado")]
        [StringLength(255)]
        [DisplayName("Nome_Almoxarifado")]
        public String Nome { get; set; }

        [Column(name: "ImagemAlmoxarifado")]
        public Byte[] Imagem { get; set; }

        [Required]
        [ForeignKey("Localizacao")]
        public int LocalizacaoId { get; set; }
        public virtual Localizacao Localizacao { get; set; }
    }
}
