using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class FamiliaDAO
    {

        private readonly ApplicationDbContext _context;

        public FamiliaDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Posicao>> Listar()
        {
            return await _context.Posicoes.ToListAsync();
        }

        public async Task Create(Familia familia)
        {
            _context.Add(familia);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(Familia familia)
        {
            _context.Remove(familia);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(Familia familia)
        {
            _context.Update(familia);
            await _context.SaveChangesAsync();
        }

    }
}
