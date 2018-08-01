using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreUI.Web.Models;
using CoreUI.Web.Data;
using CoreUI.Web.DAO;
using CoreUI.Web.Models.ViewModels;
using CoreUI.Web.Infra;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Text;

namespace CoreUI.Web.Controllers
{
    public class PDFDocumentTesteController : Controller
    {
        private readonly ApplicationDbContext _context;
        private IHostingEnvironment _hostingEnvironment;
        private DocumentacaoDAO dao;

        public PDFDocumentTesteController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
            dao = new DocumentacaoDAO(_context);
        }

        public async Task<IActionResult> Index()
        {
            ICollection <Documentacao> documentacoes = await dao.Listar();
            return View(documentacoes);
        }

        public async Task<IActionResult> Imprimir(int id)
        {
            try
            {
                var documento = await dao.GetItemById(id);

                string templatePath = @AppDomain.CurrentDomain.BaseDirectory + @"PdfTemplates\Exemplo1.pdf";
                var streamer = new DocumentacaoStreamer();
                var pdfMemoryStream = streamer.GetPdfStream(documento, templatePath);

                string contentType = "application/pdf";
                var cd = new System.Net.Mime.ContentDisposition();
                cd.Inline = true;
                cd.FileName = documento.NumCertificado.ToString();
                Response.Headers.Add("Content-Disposition", cd.ToString());

                return File(pdfMemoryStream.ToArray(), contentType);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IActionResult> ExportarExcel()
        {
            var documentacoes = await dao.Listar();

            string sWebRootFolder = _hostingEnvironment.WebRootPath;
            string sFileName = RemoveSpecialCharacters(@DateTime.Now.ToString()) + @".xlsx";
            string URL = string.Format("{0}://{1}/{2}", Request.Scheme, Request.Host, sFileName);
            FileInfo file = new FileInfo(Path.Combine(sWebRootFolder, sFileName));
            var memory = new MemoryStream();
            using (var fs = new FileStream(Path.Combine(sWebRootFolder, sFileName), FileMode.Create, FileAccess.Write))
            {
                IWorkbook workbook;
                workbook = new XSSFWorkbook();
                ISheet excelSheet = workbook.CreateSheet("Demo");
                int rownum = 0;
                IRow row = excelSheet.CreateRow(rownum);

                row.CreateCell(0).SetCellValue("Descricao");
                row.CreateCell(1).SetCellValue("Numero Certificado");
                row.CreateCell(2).SetCellValue("Data Cadastro");

                foreach (var documento in documentacoes)
                {
                    row = excelSheet.CreateRow(rownum++);
                    row.CreateCell(0).SetCellValue(documento.Descricao);
                    row.CreateCell(1).SetCellValue(documento.NumCertificado);
                    row.CreateCell(2).SetCellValue(documento.DataCadastro);
                }

                workbook.Write(fs);
            }

            using (var stream = new FileStream(Path.Combine(sWebRootFolder, sFileName), FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }

            memory.Position = 0;
            return File(memory, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", sFileName);
        }

        public string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}