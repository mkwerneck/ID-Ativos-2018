using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreUI.Web.Data;
using CoreUI.Web.DAO;
using CoreUI.Web.Models.ViewModels;
using CoreUI.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;
using System.DrawingCore;
using Microsoft.AspNetCore.Http;

namespace CoreUI.Web.Controllers
{
    public class ParametrosCorporativosController : Controller
    {
        private readonly ApplicationDbContext _context;
        private EmpresaDAO empresaDAO;
        private SetorProprietarioDAO setorProprietarioDAO;
        private FabricanteDAO fabricanteDAO;
        private ContratoDAO contratoDAO;
        private GrupoDAO grupoDAO;
        private PermissaoDAO permissaoDAO;
        private PermissaoUsuarioDAO permissaoUsuarioDAO;
        private RequisicaoDAO requisicaoDAO;
        private PurchaseOrderDAO purchaseOrderDAO;
        private IdentificacaoSistemaDAO identificacaoSistemaDAO;
        private LocalizacaoDAO localizacaoDAO;

        public ParametrosCorporativosController(ApplicationDbContext context)
        {
            _context = context;
            localizacaoDAO = new LocalizacaoDAO(context);
            empresaDAO = new EmpresaDAO(context);
            setorProprietarioDAO = new SetorProprietarioDAO(context);
            fabricanteDAO = new FabricanteDAO(context);
            contratoDAO = new ContratoDAO(context);
            grupoDAO = new GrupoDAO(context);
            permissaoDAO = new PermissaoDAO(context);
            permissaoUsuarioDAO = new PermissaoUsuarioDAO(context);
            requisicaoDAO = new RequisicaoDAO(context);
            purchaseOrderDAO = new PurchaseOrderDAO(context);
            identificacaoSistemaDAO = new IdentificacaoSistemaDAO(context);

        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Empresa> empresas = await empresaDAO.Listar();
            IEnumerable<SetorProprietario> setores = await setorProprietarioDAO.Listar();
            IEnumerable<Fabricante> fabricantes = await fabricanteDAO.Listar();
            IEnumerable<Contrato> contratos = await contratoDAO.Listar();
            IEnumerable<Grupo> grupos = await grupoDAO.Listar();
            IEnumerable<Permissao> permissoes = await permissaoDAO.Listar();
            IEnumerable<PermissaoUsuario> permissoesUsuario = await permissaoUsuarioDAO.Listar();
            IEnumerable<Requisicao> requisicoes = await requisicaoDAO.Listar();
            IEnumerable<PurchaseOrder> purchaseOrders = await purchaseOrderDAO.Listar();
            IEnumerable<IdentificacaoSistema> identificacaoSistemas = await identificacaoSistemaDAO.Listar();

            return View(new ParametrosCorporativosViewModel {
                Empresas = empresas,
                Setores = setores,
                Fabricantes = fabricantes,
                Contratos = contratos,
                Grupos = grupos,
                Permissoes = permissoes,
                PermissoesUsuarios = permissoesUsuario,
                Requisicoes = requisicoes,
                PurchaseOrders = purchaseOrders,
                IdSistemas = identificacaoSistemas
            });
        }

        #region Empresa CRUD

        [HttpGet]
        public IActionResult AddEmpresa()
        {
            return View(new Empresa());
        }

        [HttpPost]
        public async Task<IActionResult> AddEmpresa(Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                await empresaDAO.Create(empresa);
                return RedirectToAction("Index");
            }
            else
            {
                return View(empresa);
            }
        }

        [HttpGet]
        public async Task<IActionResult> EditEmpresa(int? id)
        {
            if (id.HasValue)
            {
                Empresa empresa = await empresaDAO.GetById(id);
                return View(empresa);
            }
            else
            {
                HttpContext.Response.StatusCode = 400;
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditEmpresa(Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                await empresaDAO.Edit(empresa);
                return RedirectToAction("Index");
            }
            else
            {
                HttpContext.Response.StatusCode = 400;
                return View(empresa);
            }
        }

        public async Task<IActionResult> DeleteEmpresa(int? id)
        {
            if (id.HasValue)
            {
                Empresa empresa = await empresaDAO.GetById(id);
                await empresaDAO.Remove(empresa);

                return RedirectToAction("Index");
            }
            else
            {
                HttpContext.Response.StatusCode = 400;
                return RedirectToAction("Index");
            }
        }
        #endregion

        #region Setor CRUD
        [HttpGet]
        public async Task<IActionResult> AddSetor()
        {
            await PopulateEmpresaDropDownList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddSetor(SetorProprietario setorProprietario)
        {
            if (ModelState.IsValid)
            {
                await setorProprietarioDAO.Create(setorProprietario);
                return RedirectToAction("Index");
            }

            await PopulateEmpresaDropDownList(setorProprietario.EmpresaId);
            return View(setorProprietario);
        }

        public async Task<IActionResult> EditSetor(int? id)
        {
            if (id.HasValue)
            {
                SetorProprietario setorProprietario = await setorProprietarioDAO.GetById(id);
                if (setorProprietario != null)
                {
                    await PopulateEmpresaDropDownList(setorProprietario.EmpresaId);
                    return View(setorProprietario);
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> EditSetor(SetorProprietario setorProprietario)
        {
            if (ModelState.IsValid)
            {
                await setorProprietarioDAO.Edit(setorProprietario);
                return RedirectToAction("Index");
            }

            await PopulateEmpresaDropDownList(setorProprietario.EmpresaId);
            return View(setorProprietario);
        }

        public async Task<IActionResult> DeleteSetor(int? id)
        {
            if (id.HasValue)
            {
                SetorProprietario setorProprietario = await setorProprietarioDAO.GetById(id);
                await setorProprietarioDAO.Remove(setorProprietario);

                return RedirectToAction("Index");
            }

            HttpContext.Response.StatusCode = 400;
            return RedirectToAction("Index");
        }
        #endregion

        #region Fabricante CRUD
        [HttpGet]
        public async Task<IActionResult> AddFabricante()
        {
            await PopulateEmpresaDropDownList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddFabricante(Fabricante fabricante)
        {
            if (ModelState.IsValid)
            {
                await fabricanteDAO.Create(fabricante);
                return RedirectToAction("Index");
            }

            await PopulateEmpresaDropDownList(fabricante.EmpresaId);
            return View(fabricante);
        }

        public async Task<IActionResult> EditFabricante(int? id)
        {
            if (id.HasValue)
            {
                Fabricante fabricante = await fabricanteDAO.GetById(id);
                if (fabricante != null)
                {
                    await PopulateEmpresaDropDownList(fabricante.EmpresaId);
                    return View(fabricante);
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> EditFabricante(Fabricante fabricante)
        {
            if (ModelState.IsValid)
            {
                await fabricanteDAO.Edit(fabricante);
                return RedirectToAction("Index");
            }

            await PopulateEmpresaDropDownList(fabricante.EmpresaId);
            return View(fabricante);
        }

        public async Task<IActionResult> DeleteFabricante(int? id)
        {
            if (id.HasValue)
            {
                Fabricante fabricante = await fabricanteDAO.GetById(id);
                await fabricanteDAO.Remove(fabricante);

                return RedirectToAction("Index");
            }

            HttpContext.Response.StatusCode = 400;
            return RedirectToAction("Index");
        }
        #endregion

        #region Contrato CRUD

        [HttpGet]
        public IActionResult AddContrato()
        {
            return View(new Contrato());
        }

        [HttpPost]
        public async Task<IActionResult> AddContrato(Contrato contrato)
        {
            if (ModelState.IsValid)
            {
                await contratoDAO.Create(contrato);
                return RedirectToAction("Index");
            }
            else
            {
                return View(contrato);
            }
        }

        [HttpGet]
        public async Task<IActionResult> EditContrato(int? id)
        {
            if (id.HasValue)
            {
                Contrato contrato = await contratoDAO.GetById(id);
                return View(contrato);
            }
            else
            {
                HttpContext.Response.StatusCode = 400;
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditContrato(Contrato contrato)
        {
            if (ModelState.IsValid)
            {
                await contratoDAO.Edit(contrato);
                return RedirectToAction("Index");
            }
            else
            {
                HttpContext.Response.StatusCode = 400;
                return View(contrato);
            }
        }

        public async Task<IActionResult> DeleteContrato(int? id)
        {
            if (id.HasValue)
            {
                Contrato contrato = await contratoDAO.GetById(id);
                await contratoDAO.Remove(contrato);

                return RedirectToAction("Index");
            }

            HttpContext.Response.StatusCode = 400;
            return RedirectToAction("Index");
            
        }
        #endregion

        #region Grupo CRUD

        [HttpGet]
        public async Task<IActionResult> AddGrupo()
        {
            await PopulatePermissaoUsuarioDropDownList();
            return View(new Grupo());
        }

        [HttpPost]
        public async Task<IActionResult> AddGrupo(Grupo grupo)
        {
            if (ModelState.IsValid)
            {
                await grupoDAO.Create(grupo);
                return RedirectToAction("Index");
            }

            await PopulatePermissaoUsuarioDropDownList(grupo.PermissaoUsuarioId);
            return View(grupo);
        }

        public async Task<IActionResult> EditGrupo(int? id)
        {
            if (id.HasValue)
            {
                Grupo grupo = await grupoDAO.GetById(id);
                if (grupoDAO != null)
                {
                    await PopulatePermissaoUsuarioDropDownList(grupo.PermissaoUsuarioId);
                    return View(grupo);
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> EditGrupo(Grupo grupo)
        {
            if (ModelState.IsValid)
            {
                await grupoDAO.Edit(grupo);
                return RedirectToAction("Index");
            }

            await PopulatePermissaoUsuarioDropDownList(grupo.PermissaoUsuarioId);
            return View(grupo);
        }

        public async Task<IActionResult> DeleteGrupo(int? id)
        {
            if (id.HasValue)
            {
                Grupo grupo = await grupoDAO.GetById(id);
                await grupoDAO.Remove(grupo);

                return RedirectToAction("Index");
            }

            HttpContext.Response.StatusCode = 400;
            return RedirectToAction("Index");
        }

        #endregion

        #region Permissao CRUD

        [HttpGet]
        public IActionResult AddPermissao()
        {
            return View(new Permissao());
        }

        [HttpPost]
        public async Task<IActionResult> AddPermissao(Permissao permissao)
        {
            if (ModelState.IsValid)
            {
                await permissaoDAO.Create(permissao);
                return RedirectToAction("Index");
            }
            else
            {
                return View(permissao);
            }
        }

        [HttpGet]
        public async Task<IActionResult> EditPermissao(int? id)
        {
            if (id.HasValue)
            {
                Permissao permissao = await permissaoDAO.GetById(id);
                return View(permissao);
            }
            else
            {
                HttpContext.Response.StatusCode = 400;
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditPermissao(Permissao permissao)
        {
            if (ModelState.IsValid)
            {
                await permissaoDAO.Edit(permissao);
                return RedirectToAction("Index");
            }
            else
            {
                HttpContext.Response.StatusCode = 400;
                return View(permissao);
            }
        }

        public async Task<IActionResult> DeletePermissao(int? id)
        {
            if (id.HasValue)
            {
                Permissao permissao = await permissaoDAO.GetById(id);
                await permissaoDAO.Remove(permissao);

                return RedirectToAction("Index");
            }

            HttpContext.Response.StatusCode = 400;
            return RedirectToAction("Index");

        }

        #endregion

        #region PermissaoUsuario CRUD

        [HttpGet]
        public async Task<IActionResult> AddPermissaoUsuario()
        {
            await PopulatePermissaoDropDownList();
            await PopulateGrupoDropDownList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddPermissaoUsuario(PermissaoUsuario permissaoUsuario)
        {
            if (ModelState.IsValid)
            {
                await permissaoUsuarioDAO.Create(permissaoUsuario);
                return RedirectToAction("Index");
            }

            await PopulatePermissaoDropDownList(permissaoUsuario.PermissaoId);
            await PopulateGrupoDropDownList(permissaoUsuario.GrupoId);
            return View(permissaoUsuario);
        }

        public async Task<IActionResult> EditPermissaoUsuario(int? id)
        {
            if (id.HasValue)
            {
                PermissaoUsuario permissaoUsuario = await permissaoUsuarioDAO.GetById(id);
                if (permissaoUsuario != null)
                {
                    await PopulatePermissaoDropDownList(permissaoUsuario.PermissaoId);
                    await PopulateGrupoDropDownList(permissaoUsuario.GrupoId);
                    return View(permissaoUsuario);
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> EditPermissaoUsuario(PermissaoUsuario permissaoUsuario)
        {
            if (ModelState.IsValid)
            {
                await permissaoUsuarioDAO.Edit(permissaoUsuario);
                return RedirectToAction("Index");
            }

            await PopulatePermissaoDropDownList(permissaoUsuario.PermissaoId);
            await PopulateGrupoDropDownList(permissaoUsuario.GrupoId);
            return View(permissaoUsuario);
        }

        public async Task<IActionResult> DeletePermissaoUsuario(int? id)
        {
            if (id.HasValue)
            {
                PermissaoUsuario permissaoUsuario = await permissaoUsuarioDAO.GetById(id);
                await permissaoUsuarioDAO.Remove(permissaoUsuario);

                return RedirectToAction("Index");
            }

            HttpContext.Response.StatusCode = 400;
            return RedirectToAction("Index");
        }

        #endregion

        #region Requisicao CRUD

        [HttpGet]
        public IActionResult AddRequisicao()
        {
            return View(new Requisicao());
        }

        [HttpPost]
        public async Task<IActionResult> AddRequisicao(Requisicao requisicao)
        {
            if (ModelState.IsValid)
            {
                await requisicaoDAO.Create(requisicao);
                return RedirectToAction("Index");
            }
            else
            {
                return View(requisicao);
            }
        }

        [HttpGet]
        public async Task<IActionResult> EditRequisicao(int? id)
        {
            if (id.HasValue)
            {
                Requisicao requisicao = await requisicaoDAO.GetById(id);
                return View(requisicao);
            }
            else
            {
                HttpContext.Response.StatusCode = 400;
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditRequisicao(Requisicao requisicao)
        {
            if (ModelState.IsValid)
            {
                await requisicaoDAO.Edit(requisicao);
                return RedirectToAction("Index");
            }
            else
            {
                HttpContext.Response.StatusCode = 400;
                return View(requisicao);
            }
        }

        public async Task<IActionResult> DeleteRequisicao(int? id)
        {
            if (id.HasValue)
            {
                Requisicao requisicao = await requisicaoDAO.GetById(id);
                await requisicaoDAO.Remove(requisicao);

                return RedirectToAction("Index");
            }

            HttpContext.Response.StatusCode = 400;
            return RedirectToAction("Index");

        }

        #endregion

        #region PurchaseOrder CRUD


        [HttpGet]
        public IActionResult AddPurchaseOrder()
        {
            return View(new PurchaseOrder());
        }

        [HttpPost]
        public async Task<IActionResult> AddPurchaseOrder(PurchaseOrder purchaseOrder)
        {
            if (ModelState.IsValid)
            {
                await purchaseOrderDAO.Create(purchaseOrder);
                return RedirectToAction("Index");
            }
            else
            {
                return View(purchaseOrder);
            }
        }

        [HttpGet]
        public async Task<IActionResult> EditPurchaseOrder(int? id)
        {
            if (id.HasValue)
            {
                PurchaseOrder purchaseOrder = await purchaseOrderDAO.GetById(id);
                return View(purchaseOrder);
            }
            else
            {
                HttpContext.Response.StatusCode = 400;
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditPurchaseOrder(PurchaseOrder purchaseOrder)
        {
            if (ModelState.IsValid)
            {
                await purchaseOrderDAO.Edit(purchaseOrder);
                return RedirectToAction("Index");
            }
            else
            {
                HttpContext.Response.StatusCode = 400;
                return View(purchaseOrder);
            }
        }

        public async Task<IActionResult> DeletePurchaseOrder(int? id)
        {
            if (id.HasValue)
            {
                PurchaseOrder purchaseOrder = await purchaseOrderDAO.GetById(id);
                await purchaseOrderDAO.Remove(purchaseOrder);

                return RedirectToAction("Index");
            }

            HttpContext.Response.StatusCode = 400;
            return RedirectToAction("Index");

        }

        #endregion

        #region IdentificacaoSistema CRUD

        [HttpGet]
        public async Task<IActionResult> AddIdSistema()
        {
            await PopulateLocalizacaoDropDownList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddIdSistema(AddEditIdSistemaViewModel addEditIdSistemaViewModel)
        {
            if (ModelState.IsValid)
            {

                IdentificacaoSistema identificacaoSistema = addEditIdSistemaViewModel.IdSistema;

                using (var memoryStream = new MemoryStream())
                {

                    if (addEditIdSistemaViewModel.ImgLogoWeb != null)
                    {
                        await addEditIdSistemaViewModel.ImgLogoWeb.CopyToAsync(memoryStream);
                        identificacaoSistema.LogoWeb = memoryStream.ToArray();
                    }

                    if (addEditIdSistemaViewModel.ImgLogoMobile != null)
                    {
                        await addEditIdSistemaViewModel.ImgLogoMobile.CopyToAsync(memoryStream);
                        identificacaoSistema.LogoMobile = memoryStream.ToArray();
                    }

                    if (addEditIdSistemaViewModel.ImgImagemPadrao != null)
                    {
                        await addEditIdSistemaViewModel.ImgImagemPadrao.CopyToAsync(memoryStream);
                        identificacaoSistema.ImagemPadrao = memoryStream.ToArray();
                    }
                }

                await identificacaoSistemaDAO.Create(identificacaoSistema);
                return RedirectToAction("Index");
            }

            await PopulateLocalizacaoDropDownList(addEditIdSistemaViewModel.IdSistema);
            return View(addEditIdSistemaViewModel);
        }

        public async Task<IActionResult> EditIdSistema(int? id)
        {
            if (id.HasValue)
            {
                IdentificacaoSistema identificacaoSistema = await identificacaoSistemaDAO.GetById(id);

                if (identificacaoSistema != null)
                {
                    await PopulatePermissaoDropDownList(identificacaoSistema.LocalizacaoId);
                    return View(new AddEditIdSistemaViewModel {
                        IdSistema = identificacaoSistema
                    });
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> EditIdSistema(AddEditIdSistemaViewModel addEditIdSistemaViewModel)
        {
            if (ModelState.IsValid)
            {

                IdentificacaoSistema identificacaoSistema = addEditIdSistemaViewModel.IdSistema;

                using (var memoryStream = new MemoryStream())
                {

                    if (addEditIdSistemaViewModel.ImgLogoWeb != null)
                    {
                        await addEditIdSistemaViewModel.ImgLogoWeb.CopyToAsync(memoryStream);
                        identificacaoSistema.LogoWeb = memoryStream.ToArray();
                    }

                    if (addEditIdSistemaViewModel.ImgLogoMobile != null)
                    {
                        await addEditIdSistemaViewModel.ImgLogoMobile.CopyToAsync(memoryStream);
                        identificacaoSistema.LogoMobile = memoryStream.ToArray();
                    }

                    if (addEditIdSistemaViewModel.ImgImagemPadrao != null)
                    {
                        await addEditIdSistemaViewModel.ImgImagemPadrao.CopyToAsync(memoryStream);
                        identificacaoSistema.ImagemPadrao = memoryStream.ToArray();
                    }
                }

                await identificacaoSistemaDAO.Edit(identificacaoSistema);
                return RedirectToAction("Index");
            }

            await PopulateLocalizacaoDropDownList(addEditIdSistemaViewModel.IdSistema);
            return View(addEditIdSistemaViewModel);
        }

        public async Task<IActionResult> DeleteIdSistema(int? id)
        {
            if (id.HasValue)
            {
                IdentificacaoSistema identificacaoSistema = await identificacaoSistemaDAO.GetById(id);
                await identificacaoSistemaDAO.Remove(identificacaoSistema);

                return RedirectToAction("Index");
            }

            HttpContext.Response.StatusCode = 400;
            return RedirectToAction("Index");
        }

        #endregion

        private async Task PopulateEmpresaDropDownList(object selectedEmpresa = null)
        {
            var empresas = await empresaDAO.Listar();
            ViewBag.EmpresaId = new SelectList(empresas, "Id", "NomeFantasia", selectedEmpresa);
        }

        private async Task PopulatePermissaoUsuarioDropDownList(object selectedPermissaoUsuario = null)
        {
            var permissoesUsuario = await permissaoUsuarioDAO.Listar();
            ViewBag.PermissaoUsuarioId = new SelectList(permissoesUsuario, "Id", "Usuario", selectedPermissaoUsuario);
        }

        private async Task PopulatePermissaoDropDownList(object selectedPermissao = null)
        {
            var permissao = await permissaoDAO.Listar();
            ViewBag.PermissaoId = new SelectList(permissao, "Id", "NomePermissao", selectedPermissao);
        }

        private async Task PopulateGrupoDropDownList(object selectedGrupo = null)
        {
            var grupo = await grupoDAO.Listar();
            ViewBag.GrupoId = new SelectList(grupo, "Id", "Titulo", selectedGrupo);
        }

        private async Task PopulateLocalizacaoDropDownList(object selectedLocalizacao = null)
        {
            var localizacao = await localizacaoDAO.Listar();
            ViewBag.LocalizacaoId = new SelectList(localizacao, "Id", "Descricao", selectedLocalizacao);
        }
    }
}