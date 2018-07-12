using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class ColeteorDAO
    {

        private readonly ApplicationDbContext _context;

        public ColeteorDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Posicao>> Listar()
        {
            return await _context.Posicoes.ToListAsync();
        }

        public async Task Create(Coletor coleteor)
        {
            _context.Add(coleteor);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(Coletor coleteor)
        {
            _context.Remove(coleteor);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(Coletor coleteor)
        {
            _context.Update(coleteor);
            await _context.SaveChangesAsync();
        }

    }
}
