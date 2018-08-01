using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    [Table(name: "ListaMateriaisListaTarefaEqReadnesses")]
    public class ListaMateriaisListaTarefa
    {
        [Required]
        public int Id { get; set; }
    }
}
