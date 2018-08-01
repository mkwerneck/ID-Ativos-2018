using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreUI.Web.Models.ViewModels
{
    public class AddEditSendEmail
    {
        public SendEmail sendEmail { get; set; }
        public IEnumerable<CategoriaEmail> categoriasEmail { get; set; }
    }
}
