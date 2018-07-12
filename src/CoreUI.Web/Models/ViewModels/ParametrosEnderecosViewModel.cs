using System.Collections.Generic;

namespace CoreUI.Web.Models.ViewModels
{
    public class ParametrosEnderecosViewModel
    {
        public EstadoListViewModel EstadoListViewModel { get; set; }
        public PaisListViewModel PaisListViewModel { get; set; }
        public IEnumerable<Cidade> Cidades { get; set; }
        public IEnumerable<TAGIDPosicao> TAGIDPosicoes { get; set; }
        public IEnumerable<Posicao> Posicoes { get; set; }
        public IEnumerable<Almoxarifado> Almoxarifados { get; set; }
        public IEnumerable<Localizacao> Localizacoes { get; set; }
    }
}
