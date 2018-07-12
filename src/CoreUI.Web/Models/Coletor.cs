using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreUI.Web.Models
{
    [Table(name: "ColetoresDadosSet")]
    public class Coletor
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [DisplayName("Código Leitor")]
        public String Codigo { get; set; }

        [Required]
        [DisplayName("Descrição")]
        public String Descricao { get; set; }

        [Required]
        public String Modelo { get; set; }

        [Required]
        [DisplayName("Domínio")]
        public String Dominio { get; set; }

        public String IP { get; set; }

        public String Status { get; set; }

        [DisplayName("Leitor Ativo")]
        public Boolean FlagAtivo { get; set; }

        [DisplayName("Novo Leitor")]
        public Boolean FlagNovo { get; set; }

        public Boolean FlagMobile { get; set; }

        public Boolean FlagProcess { get; set; }

        public Boolean FlagUPWEBPosicao { get; set; }

        public Boolean FlagUPWEBProprietario { get; set; }

        public Boolean FlagUPWEBServicos_Adicionais { get; set; }

        public Boolean FlagUPWEBTarefasEqRead { get; set; }

        public Boolean FlagUPWEBListaMateriaisListaTarefa { get; set; }

        public Boolean FlagUPWEBListaServicos { get; set; }

        public Boolean FlagUPWEBListaTarefasEqRead { get; set; }

        public Boolean FlagUPWEBUsuarios { get; set; }

        public Boolean FlagUPWEBInventarioEquipment { get; set; }

        public Boolean FlagUPWEBWorksheet { get; set; }

        public Boolean FlagUPWEBEquipment_Type { get; set; }

        public Boolean FlagUPWEBInventarioMaterial { get; set; }

        public Boolean FlagUPWEBMaterial_Type { get; set; }

        public Boolean FlagUPWEBWorksheetItensKit { get; set; }

        public Boolean FlagUPWEBInventarioPlanejado { get; set; }

        public Boolean FlagUPWEBListaMatInvPlanejado { get; set; }

        public Boolean FlagUPWEBGrupos { get; set; }

        [ForeignKey("Grupo")]
        public int GrupoId { get; set; }
        public virtual Grupo Grupo { get; set; }

        [Required]
        [ForeignKey("Posicao")]
        public int PosicaoId { get; set; }
        public virtual Posicao Posicao { get; set; }

    }
}
