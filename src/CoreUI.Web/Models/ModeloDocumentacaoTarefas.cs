using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    [Table(name: "Modelo_Documentacao_TarefasSet")]
    public class ModeloDocumentacaoTarefas
    {
        [Required]
        public int Id { get; set; }

        public String ModeloDocumento { get; set; }

        public String Acao { get; set; }

        public String TituloTarefa { get; set; }

        public String CodTarefa { get; set; }

        [Required]
        [ForeignKey("Tarefa")]
        public int TarefaId { get; set; }
        public virtual Tarefa Tarefa { get; set; }

        [Required]
        [ForeignKey("ModeloDocumentacao")]
        public int ModeloDocumentacaoId { get; set; }
        public virtual ModeloDocumentacao ModeloDocumentacao { get; set; }
    
    }
}
