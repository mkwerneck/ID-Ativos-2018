using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    [Table(name: "Certificadora_Classificadoras")]
    public class CertificadoraClassificadora
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
    }
}
