using System;
using System.Collections.Generic;
using System.Linq;
using CoreUI.Web.Models;

namespace CoreUI.Web.Infra
{
    public class DocumentacaoStreamer
    {

        public System.IO.MemoryStream GetPdfStream(IEnumerable<Documentacao> documentacoes, string templatePath)
        {
            var util = new PdfMergeStreamer();
            var pdfMemoryStream = new System.IO.MemoryStream();

            IEnumerable<IPdfMergeData> mergeData = this.getDocumentacaoMergeData(documentacoes);
            util.fillPDF(templatePath, mergeData, pdfMemoryStream);
            return pdfMemoryStream;

        }

        public System.IO.MemoryStream GetPdfStream(Documentacao documentacao, string templatePath)
        {
            var documentacoes = new List<Documentacao>();
            documentacoes.Add(documentacao);
            return this.GetPdfStream(documentacoes, templatePath);
        }

        IEnumerable<IPdfMergeData> getDocumentacaoMergeData(IEnumerable<Documentacao> documentacoes)
        {
            var output = new List<IPdfMergeData>();
            foreach (var documentacao in documentacoes)
            {
                output.Add(new DocumentacaoMergeData(documentacao));   
            }
            return output;
        }

    }
}
