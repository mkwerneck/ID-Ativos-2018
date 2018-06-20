using System.Collections.Generic;

namespace CoreUI.Web.Models.ViewModels
{
    public class PaisListViewModel
    {
        public IEnumerable<Pais> Paises { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
