using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    public class Grupo
    {
        [Required]
        public int Id { get; set; }

        [Required] [DisplayName("Título")]
        public String Titulo { get; set; }

        [DisplayName("Custo Operacional Diário")]
        public decimal? CustoOperacionalDiario { get; set; }

        public decimal? CustoOperacionalMensal { get; set; }

        [DisplayName("Depreciação Mensal")]
        public decimal? DepreciacaoMensal { get; set; }

        public decimal? DepreciacaoDiaria { get; set; }

        [DisplayName("Usuário Gestor")]
        public int? PermissaoUsuarioId { get; set; }
        public virtual PermissaoUsuario PermissaoUsuario {get; set;}
    }
}
