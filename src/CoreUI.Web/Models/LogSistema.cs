using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using CoreUI.Web.Models.ViewModels;

namespace CoreUI.Web.Models
{
    
    public class LogSistema
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Descrição")]
        public String Descricao { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Usuário")]
        public String Usuario { get; set; }

        [DisplayName("Data Hora - Evento")]
        public DateTime DataHoraEvento { get; set; }

        [Required]
        [StringLength(255)]
        public String Categoria { get; set; }

        //public int PagingInfoId { get; set; }
        //public IEnumerable<PagingInfo> PagingInfo { get; set; }

    }
}
