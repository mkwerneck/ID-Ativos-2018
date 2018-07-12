using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class CategoriaEmailDAO
    {

        private readonly ApplicationDbContext _context;

        public CategoriaEmailDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Posicao>> Listar()
        {
            return await _context.Posicoes.ToListAsync();
        }

        public async Task Create(CategoriaEmail categoriaEmail)
        {
            _context.Add(categoriaEmail);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(CategoriaEmail categoriaEmail)
        {
            _context.Remove(categoriaEmail);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(CategoriaEmail categoriaEmail)
        {
            _context.Update(categoriaEmail);
            await _context.SaveChangesAsync();
        }
    }
}
