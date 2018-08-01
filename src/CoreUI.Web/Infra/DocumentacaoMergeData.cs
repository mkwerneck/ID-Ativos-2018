using System.Collections.Generic;
using CoreUI.Web.Models;

namespace CoreUI.Web.Infra
{
    public class DocumentacaoMergeData : IPdfMergeData
    {
        Documentacao _documentacao;

        public DocumentacaoMergeData(Documentacao documentacao)
        {
            _documentacao = documentacao;
        }

        public IDictionary<string, string> MergeFieldValues
        {
            get { return this.getMergeDictionary(); }
        }

        IDictionary<string, string> getMergeDictionary()
        {
            var output = new Dictionary<string, string>();
            output.Add("et_descricao", _documentacao.Descricao);
            output.Add("et_numcertificado", _documentacao.NumCertificado.ToString());
            output.Add("et_datacriacao", _documentacao.DataCadastro.ToShortDateString());

            return output;
        }
    }
}
