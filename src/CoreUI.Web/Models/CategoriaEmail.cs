using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    [Table(name: "Categoria_Emails")]
    public class CategoriaEmail
    {
        [Required]
        public int Id { get; set; }

        [Required][StringLength(255)] [DisplayName("Categoria")]
        [Column(name:"Categoria")]
        public String NomeCategoria { get; set; }

        [Required] [StringLength(255)] [DisplayName("Assunto E-mail")]
        [Column(name: "Assunto_Email")]
        public String Assunto { get; set; }

        [Required] [StringLength(255)] [DataType(DataType.EmailAddress)] [DisplayName("E-mail Destinatário")]
        [Column(name: "Email_Destinatario")]
        public String EmailDestinatario { get; set; }

        [Required][StringLength(255)] [DisplayName("SMTP")]
        public String SMTP { get; set; }

        [Required][StringLength(255)][DisplayName("Remetente")]
        [Column(name: "Nome_Remetente")]
        public String NomeRemetente { get; set; }

        [Required] [StringLength(255)] [DataType(DataType.EmailAddress)] [DisplayName("Email Remetente")]
        [Column(name: "Email_Remetente")]
        public String EmailRemetente { get; set; }

        [Required][StringLength(255)][DisplayName("Senha Remetente")]
        [Column(name: "Senha_Remetente")]
        public String SenhaRemetente { get; set; }

    }
}
