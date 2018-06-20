using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class PaisDAO
    {
        private readonly ApplicationDbContext _context;

        public PaisDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Pais>> Listar()
        {
            return await _context.Pais.ToListAsync();
        }

        public async Task<Pais> GetItemById(int id)
        {
            return await _context.Pais.Where(p => p.Id == id).SingleOrDefaultAsync();
        }

        public async Task Create(Pais pais)
        {
            _context.Add(pais);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(Pais pais)
        {
            _context.Remove(pais);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(Pais pais) {
            _context.Update(pais);
            await _context.SaveChangesAsync();
        }
    }
}
