using System.Collections.Generic;

namespace CoreUI.Web.Models.ViewModels
{
    public class LogsListViewModel
    {
        public IEnumerable<LogSistema> LogsSistema { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public LogSistema LogSistemaP { get; set; }

    }
}
