using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    public class ParametrosPadrao
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Coletor")]
        public int ColetorId { get; set; }
        public virtual Coletor Coletor { get; set; }

        [Required]
        [ForeignKey("SetorProprietario")]
        public int SetorProprietarioId { get; set; }
        public virtual SetorProprietario SetorProprietario { get; set; }

        [Required]
        [ForeignKey("Almoxarifado")]
        public int AlmoxarifadoId { get; set; }
        public virtual Almoxarifado Almoxarifado { get; set; }
    }
}
