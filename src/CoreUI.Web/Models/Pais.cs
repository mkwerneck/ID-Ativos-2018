using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    [Table(name:"Paises")]
    public class Pais
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("País")]
        public String NomePais { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Abreviação")]
        public String AbreviacaoPais { get; set; }

        public Byte[] Imagem { get; set; }

    }
}
