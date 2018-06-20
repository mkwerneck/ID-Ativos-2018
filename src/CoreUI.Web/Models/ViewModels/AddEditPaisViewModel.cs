using Microsoft.AspNetCore.Http;
using System;
using System.Web;


namespace CoreUI.Web.Models.ViewModels
{
    public class AddEditPaisViewModel
    {
        public Pais Pais { get; set; }
        public IFormFile Imagem { get; set; } 
    }
}
