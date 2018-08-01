using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreUI.Web.Models.ViewModels
{
    public class ParametrosEquipamentosViewModel
    {

        public IEnumerable<TAGIDEquipment> TAGIDEquipamentos { get; set; }
        public IEnumerable<GPSIDEquipment> GPSIDEquipamentos { get; set; }
        public IEnumerable<CategoriaEquipamentos> CategoriasEquipamentos { get; set; }
        public IEnumerable<ModeloEquipamentos> ModelosEquipamentos { get; set; }

    }
}
