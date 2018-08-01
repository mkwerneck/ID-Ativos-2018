using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreUI.Web.Models.ViewModels
{
    public class ParametrosEmailsViewModel
    {
        public IEnumerable<CategoriaEmail> categoriasEmail { get; set; }
        public IEnumerable<SendEmail> sendsEmail { get; set; }
    }
}
