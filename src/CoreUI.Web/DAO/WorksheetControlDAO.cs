using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class WorksheetControlDAO
    {

        private readonly ApplicationDbContext _context;

        public WorksheetControlDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Posicao>> Listar()
        {
            return await _context.Posicoes.ToListAsync();
        }

        public async Task Create(WorksheetControl worksheetControl)
        {
            _context.Add(worksheetControl);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(WorksheetControl worksheetControl)
        {
            _context.Remove(worksheetControl);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(WorksheetControl worksheetControl)
        {
            _context.Update(worksheetControl);
            await _context.SaveChangesAsync();
        }

    }
}
