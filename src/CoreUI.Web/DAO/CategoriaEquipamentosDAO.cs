using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class CategoriaEquipamentosDAO
    {

        private readonly ApplicationDbContext _context;

        public CategoriaEquipamentosDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Posicao>> Listar()
        {
            return await _context.Posicoes.ToListAsync();
        }

        public async Task Create(CategoriaEquipamentos categoriaEquipamentos)
        {
            _context.Add(categoriaEquipamentos);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(CategoriaEquipamentos categoriaEquipamentos)
        {
            _context.Remove(categoriaEquipamentos);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(CategoriaEquipamentos categoriaEquipamentos)
        {
            _context.Update(categoriaEquipamentos);
            await _context.SaveChangesAsync();
        }

    }
}
