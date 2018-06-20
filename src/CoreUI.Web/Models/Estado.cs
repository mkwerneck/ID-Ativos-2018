using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    public class Estado
    {

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Estado")]
        public String NomeEstado { get; set; }

        [StringLength(255)]
        [DisplayName("Código Estado")]
        public String CodigoEstado { get; set; }

        [Required]
        [ForeignKey("Pais")]
        public int PaisId { get; set; }
        public virtual Pais Pais { get; set; }

    }
}
