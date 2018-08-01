using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreUI.Web.Models.ViewModels;
using CoreUI.Web.DAO;
using CoreUI.Web.Data;
using CoreUI.Web.Models;

namespace CoreUI.Web.Controllers
{
    public class ParametrosEmailsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private CategoriaEmailDAO categoriaEmailDAO;
        private SendEmailDAO sendEmailDAO;

        public ParametrosEmailsController(ApplicationDbContext context)
        {
            _context = context;
            categoriaEmailDAO = new CategoriaEmailDAO(context);
            sendEmailDAO = new SendEmailDAO(context);
        }

        public async Task<IActionResult> Index()
        {
            ICollection<CategoriaEmail> categoriasEmail = await categoriaEmailDAO.Listar();
            ICollection<SendEmail> sendEmails = await sendEmailDAO.Listar();

            return View(new ParametrosEmailsViewModel
            {
                categoriasEmail = categoriasEmail,
                sendsEmail = sendEmails
            });
        }

        [HttpGet]
        public IActionResult AddCategoriaEmail()
        {
            return View(new CategoriaEmail());
        }

        [HttpPost]
        public async Task<IActionResult> AddCategoriaEmail(CategoriaEmail categoriaEmail)
        {
            if (ModelState.IsValid)
            {
                await categoriaEmailDAO.Create(categoriaEmail);
                return RedirectToAction("Index");
            }
            HttpContext.Response.StatusCode = 400;
            return View(categoriaEmail);
        }

        [HttpGet]
        public async Task<IActionResult> EditCategoriaEmails(int id)
        {
            CategoriaEmail categoriaEmail = await categoriaEmailDAO.GetById(id);

            if (categoriaEmail != null)
            {
                return View(categoriaEmail);
            }
            else
            {
                HttpContext.Response.StatusCode = 400;
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditCategoriaEmails(CategoriaEmail categoriaEmail)
        {
            if (ModelState.IsValid)
            {
                await categoriaEmailDAO.Edit(categoriaEmail);
                return RedirectToAction("Index");
            }
            else
            {
                HttpContext.Response.StatusCode = 400;
                return View(categoriaEmail);
            }
        }

        public async Task<IActionResult> DeleteCategoriaEmails(int id)
        {
            CategoriaEmail categoriaEmail = await categoriaEmailDAO.GetById(id);

            if (categoriaEmail != null)
            {
                await categoriaEmailDAO.Remove(categoriaEmail);
            }
            else
            {
                HttpContext.Response.StatusCode = 400;
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> AddSendEmails()
        {
            IEnumerable<CategoriaEmail> categoriasEmail = await categoriaEmailDAO.Listar();

            return View(new AddEditSendEmail
            {
                sendEmail = new SendEmail(),
                categoriasEmail = categoriasEmail
            });
        }

        [HttpPost]
        public async Task<IActionResult> AddSendEmails(SendEmail sendEmail)
        {
            IEnumerable<CategoriaEmail> categoriasEmail = await categoriaEmailDAO.Listar();

            if (ModelState.IsValid)
            {
                await sendEmailDAO.Create(sendEmail);
                return RedirectToAction("Index");
            }
            else
            {
                HttpContext.Response.StatusCode = 400;
                return View(new AddEditSendEmail {
                    sendEmail = sendEmail,
                    categoriasEmail = categoriasEmail
                });
            }
        }

        [HttpGet]
        public async Task<IActionResult> EditSendEmails(int id)
        {
            SendEmail sendEmail = await sendEmailDAO.GetById(id);
            IEnumerable <CategoriaEmail> categoriasEmail = await categoriaEmailDAO.Listar();

            if (sendEmail != null)
            {
                return View(new AddEditSendEmail
                {
                    sendEmail = sendEmail,
                    categoriasEmail = categoriasEmail
                });
            }
            else
            {
                HttpContext.Response.StatusCode = 400;
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditSendEmails(SendEmail sendEmail)
        {
            IEnumerable<CategoriaEmail> categoriasEmail = await categoriaEmailDAO.Listar();

            if (ModelState.IsValid)
            {
                await sendEmailDAO.Edit(sendEmail);
                return RedirectToAction("Index");
            }
            else
            {
                HttpContext.Response.StatusCode = 400;
                return RedirectToAction("Index");
            }
        }

        public async Task<IActionResult> DeleteSendEmails(int id)
        {
            SendEmail sendEmail = await sendEmailDAO.GetById(id);

            if (sendEmail != null)
            {
                await sendEmailDAO.Remove(sendEmail);
                return RedirectToAction("Index");
            }
            else
            {
                HttpContext.Response.StatusCode = 400;
                return RedirectToAction("Index");
            }
        }

    }
}