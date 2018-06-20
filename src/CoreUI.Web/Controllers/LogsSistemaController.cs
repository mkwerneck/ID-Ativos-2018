using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreUI.Web.Models;
using CoreUI.Web.Data;
using CoreUI.Web.DAO;
using CoreUI.Web.Models.ViewModels;

namespace CoreUI.Web.Controllers
{
    public class LogsSistemaController : Controller
    {
        private readonly ApplicationDbContext _context;
        private LogsSistemaDAO dao;
        public int PageSize = 10;

        public LogsSistemaController(ApplicationDbContext context) {
            _context = context;
            dao = new LogsSistemaDAO(_context);
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            ICollection<LogSistema> logSistemas = await dao.Listar();
            return View(new LogsListViewModel
            {
                LogsSistema = logSistemas
                    .OrderBy(p => p.Id)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = logSistemas.Count()
                }
            });
        }

        public async Task<IActionResult> Delete(int Id)
        {
            var logSistema = await dao.GetItemById(Id);
            await dao.Delete(logSistema);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int id)
        {
            var logSistema = await dao.GetItemById(id);
            return View(logSistema);
        }

        public IActionResult Create(LogSistema logSistema)
        {         
            return View(new LogSistema());
        }

        [HttpPost]
        public async Task<IActionResult> New(LogSistema logSistema) {
            if (ModelState.IsValid)
            {
                await dao.Create(logSistema);
                return RedirectToAction("Index");
            } else {
                return RedirectToAction("Create", logSistema);
            }
        }

        public async Task<IActionResult> Edit(int Id)
        {
            var logSistema = await dao.GetItemById(Id);
            return View(logSistema);
        }

        [HttpPost]
        public async Task<IActionResult> Update(LogSistema logSistema)
        {
            await dao.Update(logSistema);
            return RedirectToAction("Index");
        }
    }
}