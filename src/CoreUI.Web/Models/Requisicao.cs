using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    [Table(name: "RequisiçãoTableSet")]
    public class Requisicao
    {
        [Required]
        public int Id { get; set; }

        [Required][StringLength(255)]
        public String RQ { get; set; }
    }
}
