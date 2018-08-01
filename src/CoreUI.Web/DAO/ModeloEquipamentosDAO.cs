using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class ModeloEquipamentosDAO
    {

        private readonly ApplicationDbContext _context;

        public ModeloEquipamentosDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<ModeloEquipamentos>> Listar()
        {
            return await _context.ModelosEquipamentos
                .Include(p => p.Fabricante)
                .ToListAsync();
        }

        public async Task Create(ModeloEquipamentos modeloEquipamentos)
        {
            _context.Add(modeloEquipamentos);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(ModeloEquipamentos modeloEquipamentos)
        {
            _context.Remove(modeloEquipamentos);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(ModeloEquipamentos modeloEquipamentos)
        {
            _context.Update(modeloEquipamentos);
            await _context.SaveChangesAsync();
        }

    }
}
