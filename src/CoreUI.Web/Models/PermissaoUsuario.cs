using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    public class PermissaoUsuario
    {
        [Required]
        public int Id { get; set; }

        [Required][DisplayName("Usuário")]
        public String Usuario { get; set; }

        [DisplayName("E-mail Usuário")]
        public String EmailUsuario { get; set; }

        [DisplayName("Nome Completo")]
        public String NomeCompleto { get; set; }

        public float? DuracaoExpediente {get; set;}

        [DisplayName("TAGID do Usuário")]
        public String TAGID { get; set; }

        [DisplayName("Permissão")]
        public int PermissaoId { get; set; }
        public virtual Permissao Permissao { get; set; }

        [DisplayName("Grupo de Execução")]
        public int? GrupoId { get; set; }
        public virtual Grupo Grupo { get; set; }

    }
}
