using System.Collections.Generic;

namespace CoreUI.Web.Models.ViewModels
{
    public class EstadoListViewModel
    {
        public IEnumerable<Estado> Estados { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
