using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    public class Permissao
    {
        [Required]
        public int Id { get; set; }

        [Required][DisplayName("Permissão")]
        public String NomePermissao { get; set; }


    }
}
