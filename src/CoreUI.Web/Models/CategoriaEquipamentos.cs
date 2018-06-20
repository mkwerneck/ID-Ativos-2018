using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    [Table(name: "Categoria_EquipamentosSet")]
    public class CategoriaEquipamentos
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public String Categoria { get; set; }
    }
}
