using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreUI.Web.Models.ViewModels
{
    public class AddEditCidadeViewModel
    {
        public Cidade Cidade { get; set; }
        public ICollection<Estado> Estados { get; set; }
    }
}
