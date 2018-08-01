using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class GrupoDAO
    {

        private readonly ApplicationDbContext _context;

        public GrupoDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Grupo>> Listar()
        {
            return await _context.Grupos
                .ToListAsync();
        }

        public async Task Create(Grupo grupo)
        {
            _context.Add(grupo);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(Grupo grupo)
        {
            _context.Remove(grupo);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(Grupo grupo)
        {
            _context.Update(grupo);
            await _context.SaveChangesAsync();
        }

        public async Task<Grupo> GetById(int? id)
        {
            Grupo grupo = await _context.Grupos
                .Include(p => p.PermissaoUsuario)
                .AsNoTracking()
                .SingleOrDefaultAsync(p => p.Id == id);
            return grupo;
        }

    }
}
