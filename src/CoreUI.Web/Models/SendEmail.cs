using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    [Table(name: "Send_Emails")]
    public class SendEmail
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(255)] [DisplayName("Identificação")]
        public String Identificacao { get; set; }

        [Required]
        [StringLength(255)] [DataType(DataType.EmailAddress)] [DisplayName("E-mail")]
        public String Email { get; set; }

        [Required]
        public int CategoriaEmailId { get; set; }
        public virtual CategoriaEmail CategoriaEmail { get; set; }
    }
}
