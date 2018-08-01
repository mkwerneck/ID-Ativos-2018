using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    public class PermissaoHabilitacao
    {
        [Required]
        public int Id { get; set; }

        public Boolean FlagTodosGrupos { get; set; }

        public Boolean FlagTodasCategorias {get; set;}

        public Boolean FlagTodasEmpresasEquipamentos { get; set; }

        public Boolean FlagTodosProprietarios { get; set; }

        public int GrupoId { get; set; }
        public virtual Grupo Grupo { get; set; }

        public int CategoriaEquipamentosId { get; set; }
        public virtual CategoriaEquipamentos CategoriaEquipamentos { get; set; }

        public int EmpresaId { get; set; }
        public virtual Empresa Empresa { get; set; }

        public int PermissaoId { get; set; }
        public virtual Permissao Permissao { get; set; }

        public int SetorProprietarioId { get; set; }
        public virtual SetorProprietario SetorProprietario { get; set; }

    }
}
