using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreUI.Web.Models.ViewModels
{
    public class AddEditEstadoViewModel
    {
        public Estado Estado { get; set; }
        public ICollection<Pais> Paises { get; set; }

    }
}
