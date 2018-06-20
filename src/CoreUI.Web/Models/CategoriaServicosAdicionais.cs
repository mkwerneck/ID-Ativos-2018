using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    [Table(name: "Categoria_Servicos_AdicionaisSet")]
    public class CategoriaServicosAdicionais
    {
        [Required]
        public int Id { get; set; }

        [Required] [StringLength(255)]
        public String Categoria { get; set; }

        [Required] [StringLength(255)] [DisplayName("Descrição")]
        [Column(name: "Descricao_Categoria")]
        public String DescricaoCategoria { get; set; }
    }
}
