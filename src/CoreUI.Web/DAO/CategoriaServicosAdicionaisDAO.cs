using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class CategoriaServicosAdicionaisDAO
    {

        private readonly ApplicationDbContext _context;

        public CategoriaServicosAdicionaisDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Posicao>> Listar()
        {
            return await _context.Posicoes.ToListAsync();
        }

        public async Task Create(CategoriaServicosAdicionais categoriaServicosAdicionais)
        {
            _context.Add(categoriaServicosAdicionais);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(CategoriaServicosAdicionais categoriaServicosAdicionais)
        {
            _context.Remove(categoriaServicosAdicionais);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(CategoriaServicosAdicionais categoriaServicosAdicionais)
        {
            _context.Update(categoriaServicosAdicionais);
            await _context.SaveChangesAsync();
        }

    }
}
