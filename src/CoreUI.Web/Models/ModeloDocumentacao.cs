using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    [Table(name:"Modelo_Documentoes")]
    public class ModeloDocumentacao
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public String Descricao { get; set; }
    }
}
