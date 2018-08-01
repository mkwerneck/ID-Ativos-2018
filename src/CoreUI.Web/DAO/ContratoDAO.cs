using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class ContratoDAO
    {

        private readonly ApplicationDbContext _context;

        public ContratoDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Contrato>> Listar()
        {
            return await _context.Contratos
                .ToListAsync();
        }

        public async Task Create(Contrato contrato)
        {
            _context.Add(contrato);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(Contrato contrato)
        {
            _context.Remove(contrato);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(Contrato contrato)
        {
            _context.Update(contrato);
            await _context.SaveChangesAsync();
        }

        public async Task<Contrato> GetById(int? id)
        {
            Contrato contrato = await _context.Contratos
                .AsNoTracking()
                .SingleOrDefaultAsync(p => p.Id == id);
            return contrato;
        }

    }
}
