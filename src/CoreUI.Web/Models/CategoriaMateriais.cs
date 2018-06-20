using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    [Table(name: "Categoria_MateriaisSet")]
    public class CategoriaMateriais
    {
        [Required]
        public int id { get; set; }

        [Required][StringLength(255)]
        public String Categoria { get; set; }
    }
}
