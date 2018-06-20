using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreUI.Web.Models
{
    public class Tarefa
    {
        public int Id { get; set; }

        public String Codigo { get; set; }

        public String Titulo { get; set; }

        public String Tipo { get; set; }

        public String Predecessora { get; set; }

        public String SucessoraSIM { get; set; }

        public String SucessoraNAO { get; set; }

        public int TempoExecucao { get; set; }

        public String Descricao { get; set; }

        public String Observacao { get; set; }

        public String StatusConclusaoProcesso { get; set; }

        public Boolean FlagIncluirResultado { get; set; }

        public Boolean FlagAtualizarEstoque { get; set; }

        public Boolean FlagEntradaAlmoxarifado { get; set; }

        public Boolean FlagDependenciaSaldo { get; set; }

        public Boolean FlagSendEmail { get; set; }

        public Boolean FlagDuracaoTarefa { get; set; }

        public Boolean FlagDependenciaServico { get; set; }

        public String StatusAtualizacaoTarefa { get; set; }

        public String CodicaoAtualizacaoTarefa { get; set; }

        public Boolean FlagCopyListaMateriais { get; set; }

        public Boolean FlagCopyListaServicos { get; set; }

        public int GrupoId { get; set; }
        public Grupo Grupo { get; set; }

        public int CategoriaEquipamentosId { get; set; }
        public CategoriaEquipamentos CategoriaEquipamentos { get; set; }
    }
}
