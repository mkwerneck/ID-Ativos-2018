using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreUI.Web.Models;
using CoreUI.Web.Data;
using CoreUI.Web.DAO;
using CoreUI.Web.Models.ViewModels;
using System.IO;

namespace CoreUI.Web.Controllers
{
    public class ParametrosEnderecosController : Controller
    {
        private readonly ApplicationDbContext _context;
        private PaisDAO paisDao;
        private CidadeDAO cidadeDAO;
        private EstadoDAO estadoDAO;
        private TAGIDPosicaoDAO tagidPosicaoDAO;
        private PosicaoDAO posicaoDAO;
        private AlmoxarifadoDAO almoxarifadoDAO;
        private LocalizacaoDAO localizacaoDAO;
        public int PageSize = 3;

        public ParametrosEnderecosController(ApplicationDbContext context)
        {
            _context = context;
            paisDao = new PaisDAO(_context);
            cidadeDAO = new CidadeDAO(_context);
            estadoDAO = new EstadoDAO(_context);
            tagidPosicaoDAO = new TAGIDPosicaoDAO(_context);
            posicaoDAO = new PosicaoDAO(_context);
            almoxarifadoDAO = new AlmoxarifadoDAO(_context);
            localizacaoDAO = new LocalizacaoDAO(_context);
        }

        public async Task <IActionResult> Index(int page = 1)
        {
            ICollection<Pais> paises = await paisDao.Listar();
            ICollection<Estado> estados = await estadoDAO.Listar();
            ICollection<Cidade> cidades = await cidadeDAO.Listar();
            ICollection<TAGIDPosicao> tagidPosicoes = await tagidPosicaoDAO.Listar();
            ICollection<Posicao> posicoes = await posicaoDAO.Listar();
            ICollection<Almoxarifado> almoxarifados = await almoxarifadoDAO.Listar();
            ICollection<Localizacao> localizacaos = await localizacaoDAO.Listar();

            return View(new ParametrosEnderecosViewModel {
                PaisListViewModel = new PaisListViewModel {
                    Paises = paises
                        .Skip((page - 1) * PageSize)
                        .Take(PageSize),
                    PagingInfo = new PagingInfo {
                        CurrentPage = page,
                        ItemsPerPage = PageSize,
                        TotalItems = paises.Count()
                    }
                },

                Estados = estados,
                Cidades = cidades,
                TAGIDPosicoes = tagidPosicoes,
                Posicoes = posicoes,
                Almoxarifados = almoxarifados,
                Localizacoes = localizacaos
                
            });
        }

        [HttpGet]
        public IActionResult AddPais()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddPais(AddEditPaisViewModel addEditPaisViewModel)
        {
            var pais = addEditPaisViewModel.Pais;
            using (var memoryStream = new MemoryStream())
            {
                await addEditPaisViewModel.Imagem.CopyToAsync(memoryStream);
                pais.Imagem = memoryStream.ToArray();
            }

            await paisDao.Create(pais);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task <IActionResult> AddEstado()
        {
            ICollection<Pais> paises = await paisDao.Listar();

            return View(new AddEditEstadoViewModel {
                Estado = new Estado(),
                Paises = paises
            });
        }

        [HttpPost]
        public async Task<IActionResult> AddEstado(AddEditEstadoViewModel addEditEstadoViewModel)
        {
            await estadoDAO.Create(addEditEstadoViewModel.Estado);        
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> AddCidade()
        {
            ICollection<Estado> estados = await estadoDAO.Listar();

            return View(new AddEditCidadeViewModel
            {
                Cidade = new Cidade(),
                Estados = estados
            });
        }

        [HttpPost]
        public async Task<IActionResult> AddCidade(AddEditCidadeViewModel addEditCidadeViewModel)
        {
            await cidadeDAO.Create(addEditCidadeViewModel.Cidade);
            return RedirectToAction("Index");
        }
    }
}