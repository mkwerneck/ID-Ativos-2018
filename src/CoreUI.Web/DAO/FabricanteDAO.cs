using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class FabricanteDAO
    {

        private readonly ApplicationDbContext _context;

        public FabricanteDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Posicao>> Listar()
        {
            return await _context.Posicoes.ToListAsync();
        }

        public async Task Create(Fabricante fabricante)
        {
            _context.Add(fabricante);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(Fabricante fabricante)
        {
            _context.Remove(fabricante);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(Fabricante fabricante)
        {
            _context.Update(fabricante);
            await _context.SaveChangesAsync();
        }

    }
}
