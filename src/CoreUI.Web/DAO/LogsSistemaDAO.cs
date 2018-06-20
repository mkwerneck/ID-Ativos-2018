using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class LogsSistemaDAO
    {
        private readonly ApplicationDbContext _context;

        public LogsSistemaDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<LogSistema>> Listar()
        {
            return await _context.LogSistema.ToListAsync();
        }

        public async Task<LogSistema> GetItemById(int id)
        {
            return await _context.LogSistema.Where(p => p.Id == id).SingleAsync();
        }

        public async Task Delete(LogSistema logSistema) {
            _context.Remove(logSistema);
            await _context.SaveChangesAsync();
        }

        public async Task Create(LogSistema logSistema)
        {
            _context.Add(logSistema);
            await _context.SaveChangesAsync();
        }

        public async Task Update(LogSistema logSistema)
        {
            _context.Update(logSistema);
            await _context.SaveChangesAsync();
        }

        public async Task<ICollection<LogSistema>> ListbyCategory(String Categoria)
        {
            return await _context.LogSistema.Where(p => p.Categoria == Categoria).ToListAsync();
        }
    }
}
