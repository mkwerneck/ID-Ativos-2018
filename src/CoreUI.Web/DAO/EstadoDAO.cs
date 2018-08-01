using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class EstadoDAO
    {

        private readonly ApplicationDbContext _context;

        public EstadoDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Estado>> Listar()
        {
            return await _context.Estados
                .ToListAsync();
        }

        public async Task Create(Estado estado)
        {
            _context.Add(estado);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(Estado estado)
        {
            _context.Remove(estado);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(Estado estado)
        {
            _context.Update(estado);
            await _context.SaveChangesAsync();
        }

    }
}
