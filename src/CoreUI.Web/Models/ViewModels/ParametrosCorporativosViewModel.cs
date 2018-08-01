using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreUI.Web.Models.ViewModels
{
    public class ParametrosCorporativosViewModel
    {
        public IEnumerable<Empresa> Empresas { get; set; }
        public IEnumerable<SetorProprietario> Setores { get; set; }
        public IEnumerable<Fabricante> Fabricantes { get; set; }

        public IEnumerable<Contrato> Contratos { get; set; }
        public IEnumerable<Grupo> Grupos { get; set; }
        public IEnumerable<Permissao> Permissoes { get; set; }

        public IEnumerable<PermissaoUsuario> PermissoesUsuarios { get; set; }
        //public IEnumerable<PermissaoHabilitacao> PermissoesHabilitacao { get; set; }
        public IEnumerable<Requisicao> Requisicoes { get; set; }

        public IEnumerable<PurchaseOrder> PurchaseOrders { get; set; }
        public IEnumerable<IdentificacaoSistema> IdSistemas { get; set; }
    }
}
