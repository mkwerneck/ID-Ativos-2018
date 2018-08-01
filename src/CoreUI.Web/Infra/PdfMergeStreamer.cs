using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections.Generic;
using CoreUI.Web.Models;

namespace CoreUI.Web.Infra
{
    public class PdfMergeStreamer
    {
        public void fillPDF(string templatePath, IEnumerable<IPdfMergeData> mergeDataItems, 
            System.IO.MemoryStream outputstream)
        {
            var pagesAll = new List<byte[]>();

            byte[] pageBytes = null;

            foreach (var mergeItem in mergeDataItems)
            {
                var templateReader = new iTextSharp.text.pdf.PdfReader(templatePath);
                using (var tempStream = new System.IO.MemoryStream())
                {
                    PdfStamper stamper = new PdfStamper(templateReader, tempStream);
                    stamper.FormFlattening = true;
                    AcroFields fields = stamper.AcroFields;
                    stamper.Writer.CloseStream = false;

                    var fieldVals = mergeItem.MergeFieldValues;

                    foreach (string name in fieldVals.Keys)
                    {
                        fields.SetField(name, fieldVals[name]);
                    }

                    stamper.Close();

                    tempStream.Position = 0;

                    pageBytes = tempStream.ToArray();

                    pagesAll.Add(pageBytes);
                }
            }

            Document mainDocument = new Document(PageSize.A4);

            var pdfCopier = new PdfSmartCopy(mainDocument, outputstream);

            pdfCopier.CloseStream = false;

            mainDocument.Open();
            foreach (var pageByteArray in pagesAll)
            {
                mainDocument.NewPage();
                pdfCopier.AddPage(pdfCopier.GetImportedPage(new PdfReader(pageByteArray), 1));
            }
            pdfCopier.Close();

            outputstream.Position = 0;
        }
    }
}
