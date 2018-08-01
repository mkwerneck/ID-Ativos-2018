using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    [Table(name: "Documentacaos")]
    public class Documentacao
    {

        [Required]
        public int Id { get; set; }

        [Required]
        public String Descricao { get; set; }

        public String Status { get; set; }

        [Required]
        public DateTime DataCadastro { get; set; }

        public DateTime DataEmissao { get; set; }

        public DateTime DataValidade { get; set; }

        public DateTime DataImpressao { get; set; }

        public DateTime DataCancelado { get; set; }

        public String UsuarioCadastro { get; set; }

        public String UsuarioEmissor { get; set; }

        public String UsuarioCancelamento { get; set; }

        [Required]
        public long NumCertificado { get; set; }

        public String Obsrevacao { get; set; }

        public String NumCertificadoString { get; set; }

        //[ForeignKey("WorksheetControl")]
        //public int WorksheetControlId { get; set; }
        //public virtual WorksheetControl WorksheetControl { get; set; }

        //S
    }
}
