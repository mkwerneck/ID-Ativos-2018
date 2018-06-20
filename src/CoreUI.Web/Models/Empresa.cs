using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    [Table(name: "Empresas")]
    public class Empresa
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Nome Fantasia")]
        public String NomeFantasia { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Razão Social")]
        public String RazaoSocial { get; set; }

        [Required]
        [StringLength(255)]
        public String CNPJ { get; set; }

        [StringLength(255)]
        [DisplayName("Inscrição Estadual")]
        public String InscricaoEstadual { get; set; }

        [StringLength(255)]
        [DisplayName("Inscrição Municipal")]
        public String InscricaoMunicipal { get; set; }

        public int CNAE { get; set; }

        public int CRT { get; set; }

    }
}
