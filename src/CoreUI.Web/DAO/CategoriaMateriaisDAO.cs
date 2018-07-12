using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class CategoriaMateriaisDAO
    {

        private readonly ApplicationDbContext _context;

        public CategoriaMateriaisDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Posicao>> Listar()
        {
            return await _context.Posicoes.ToListAsync();
        }

        public async Task Create(CategoriaMateriais categoriaMateriais)
        {
            _context.Add(categoriaMateriais);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(CategoriaMateriais categoriaMateriais)
        {
            _context.Remove(categoriaMateriais);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(CategoriaMateriais categoriaMateriais)
        {
            _context.Update(categoriaMateriais);
            await _context.SaveChangesAsync();
        }

    }
}
