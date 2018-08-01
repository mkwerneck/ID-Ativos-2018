using Microsoft.AspNetCore.Http;
using System;
using System.Web;

namespace CoreUI.Web.Models.ViewModels
{
    public class AddEditIdSistemaViewModel
    {
        public IdentificacaoSistema IdSistema { get; set; }
        public IFormFile ImgLogoWeb { get; set; }
        public IFormFile ImgLogoMobile { get; set; }
        public IFormFile ImgImagemPadrao { get; set; }
    }
}
