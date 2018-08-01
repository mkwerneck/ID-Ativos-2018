using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class PermissaoUsuarioDAO
    {

        private readonly ApplicationDbContext _context;

        public PermissaoUsuarioDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<PermissaoUsuario>> Listar()
        {
            return await _context.PermissoesUsuario
                .Include(p => p.Permissao)
                .ToListAsync();
        }

        public async Task Create(PermissaoUsuario permissaoUsuario)
        {
            _context.Add(permissaoUsuario);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(PermissaoUsuario permissaoUsuario)
        {
            _context.Remove(permissaoUsuario);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(PermissaoUsuario permissaoUsuario)
        {
            _context.Update(permissaoUsuario);
            await _context.SaveChangesAsync();
        }

        public async Task<PermissaoUsuario> GetById(int? id)
        {
            PermissaoUsuario permissaoUsuario = await _context.PermissoesUsuario
                .Include(p => p.Grupo)
                .Include(p => p.Permissao)
                .AsNoTracking()
                .SingleOrDefaultAsync(p => p.Id == id);
            return permissaoUsuario;
        }

    }
}
