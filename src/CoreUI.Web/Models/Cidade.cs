using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    public class Cidade
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Cidade")]
        public String NomeCidade { get; set; }

        [Required]
        [ForeignKey("Estado")]
        public int EstadoId { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
