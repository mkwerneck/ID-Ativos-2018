using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using CoreUI.Web.DAO;
using CoreUI.Web.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreUI.Web.Controllers
{
    public class ParametrosEquipamentosController : Controller
    {
        private readonly ApplicationDbContext _context;
        private FabricanteDAO fabricanteDAO;
        private TAGIDEquipmentDAO tagidEquipmentDAO;
        private GPSIDEquipmentDAO gpsidEquipmentDAO;
        private CategoriaEquipamentosDAO categoriaEquipamentosDAO;
        private ModeloEquipamentosDAO modeloEquipamentosDAO;

        public ParametrosEquipamentosController(ApplicationDbContext context)
        {
            _context = context;

            fabricanteDAO = new FabricanteDAO(context);
            tagidEquipmentDAO = new TAGIDEquipmentDAO(context);
            gpsidEquipmentDAO = new GPSIDEquipmentDAO(context);
            categoriaEquipamentosDAO = new CategoriaEquipamentosDAO(context);
            modeloEquipamentosDAO = new ModeloEquipamentosDAO(context);

        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<TAGIDEquipment> tagidEquipment = await tagidEquipmentDAO.Listar();
            IEnumerable<GPSIDEquipment> gpsidEquipment = await gpsidEquipmentDAO.Listar();
            IEnumerable<CategoriaEquipamentos> categoriaEquipamentos = await categoriaEquipamentosDAO.Listar();
            IEnumerable<ModeloEquipamentos> modeloEquipamentos = await modeloEquipamentosDAO.Listar();

            return View(new ParametrosEquipamentosViewModel
            {

                TAGIDEquipamentos = tagidEquipment,
                GPSIDEquipamentos = gpsidEquipment,
                CategoriasEquipamentos = categoriaEquipamentos,
                ModelosEquipamentos = modeloEquipamentos
                
            });
        }

        #region TAGIDEquipamento CRUD

        [HttpGet]
        public IActionResult AddTAGIDEquipment()
        {
            return View(new TAGIDEquipment());
        }

        [HttpPost]
        public async Task<IActionResult> AddTAGIDEquipment(TAGIDEquipment tagidEquipment)
        {
            if (ModelState.IsValid)
            {
                await tagidEquipmentDAO.Create(tagidEquipment);
                return RedirectToAction("Index");
            }
            else
            {
                return View(tagidEquipment);
            }
        }

        [HttpGet]
        public async Task<IActionResult> EditTAGIDEquipment(int? id)
        {
            if (id.HasValue)
            {
                TAGIDEquipment tagidEquipment = await tagidEquipmentDAO.GetById(id);
                return View(tagidEquipment);
            }
            else
            {
                HttpContext.Response.StatusCode = 400;
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditTAGIDEquipment(TAGIDEquipment tagidEquipment)
        {
            if (ModelState.IsValid)
            {
                await tagidEquipmentDAO.Edit(tagidEquipment);
                return RedirectToAction("Index");
            }
            else
            {
                HttpContext.Response.StatusCode = 400;
                return View(tagidEquipment);
            }
        }

        public async Task<IActionResult> DeleteTAGIDEquipment(int? id)
        {
            if (id.HasValue)
            {
                TAGIDEquipment tagidEquipment = await tagidEquipmentDAO.GetById(id);
                await tagidEquipmentDAO.Remove(tagidEquipment);

                return RedirectToAction("Index");
            }

            HttpContext.Response.StatusCode = 400;
            return RedirectToAction("Index");

        }
        #endregion

        #region GPSIDEquipment CRUD

        [HttpGet]
        public IActionResult AddGPSIDEquipment()
        {
            return View(new GPSIDEquipment());
        }

        [HttpPost]
        public async Task<IActionResult> AddGPSIDEquipment(GPSIDEquipment gpsidEquipment)
        {
            if (ModelState.IsValid)
            {
                await gpsidEquipmentDAO.Create(gpsidEquipment);
                return RedirectToAction("Index");
            }
            else
            {
                return View(gpsidEquipment);
            }
        }

        [HttpGet]
        public async Task<IActionResult> EditGPSIDEquipment(int? id)
        {
            if (id.HasValue)
            {
                GPSIDEquipment gpsidEquipment = await gpsidEquipmentDAO.GetById(id);
                return View(gpsidEquipment);
            }
            else
            {
                HttpContext.Response.StatusCode = 400;
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditGPSIDEquipment(GPSIDEquipment gpsidEquipment)
        {
            if (ModelState.IsValid)
            {
                await gpsidEquipmentDAO.Edit(gpsidEquipment);
                return RedirectToAction("Index");
            }
            else
            {
                HttpContext.Response.StatusCode = 400;
                return View(gpsidEquipment);
            }
        }

        public async Task<IActionResult> DeleteGPSIDEquipment(int? id)
        {
            if (id.HasValue)
            {
                GPSIDEquipment gpsidEquipment = await gpsidEquipmentDAO.GetById(id);
                await gpsidEquipmentDAO.Remove(gpsidEquipment);

                return RedirectToAction("Index");
            }

            HttpContext.Response.StatusCode = 400;
            return RedirectToAction("Index");

        }

        #endregion

        #region CategoriaEquipamentos CRUD


        [HttpGet]
        public IActionResult AddCategoriaEquipamentos()
        {
            return View(new CategoriaEquipamentos());
        }

        [HttpPost]
        public async Task<IActionResult> AddCategoriaEquipamentos(CategoriaEquipamentos categoriaEquipamentos)
        {
            if (ModelState.IsValid)
            {
                await categoriaEquipamentosDAO.Create(categoriaEquipamentos);
                return RedirectToAction("Index");
            }
            else
            {
                return View(categoriaEquipamentos);
            }
        }

        [HttpGet]
        public async Task<IActionResult> EditCategoriaEquipamentos(int? id)
        {
            if (id.HasValue)
            {
                CategoriaEquipamentos categoriaEquipamentos = await categoriaEquipamentosDAO.GetById(id);
                return View(categoriaEquipamentos);
            }
            else
            {
                HttpContext.Response.StatusCode = 400;
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditCategoriaEquipamentos(CategoriaEquipamentos categoriaEquipamentos)
        {
            if (ModelState.IsValid)
            {
                await categoriaEquipamentosDAO.Edit(categoriaEquipamentos);
                return RedirectToAction("Index");
            }
            else
            {
                HttpContext.Response.StatusCode = 400;
                return View(categoriaEquipamentos);
            }
        }

        public async Task<IActionResult> DeleteCategoriaEquipamentos(int? id)
        {
            if (id.HasValue)
            {
                CategoriaEquipamentos categoriaEquipamentos = await categoriaEquipamentosDAO.GetById(id);
                await categoriaEquipamentosDAO.Remove(categoriaEquipamentos);

                return RedirectToAction("Index");
            }

            HttpContext.Response.StatusCode = 400;
            return RedirectToAction("Index");

        }

        #endregion

        #region ModeloEquipamentos CRUD



        #endregion

        private async Task PopulateFabricanteDropDownList(object selectedFabricante = null)
        {
            var fabricantes = await fabricanteDAO.Listar();
            ViewBag.FabricanteId = new SelectList(fabricantes, "Id", "NomeFabricante", selectedFabricante);
        }

        private async Task PopulateCategoriaEquipamentoDropDownList(object selectedCategoria = null)
        {
            var categorias = await categoriaEquipamentosDAO.Listar();
            ViewBag.CategoriaEquipamentoId = new SelectList(categorias, "Id", "Categoria", selectedCategoria);
        }

    }
}