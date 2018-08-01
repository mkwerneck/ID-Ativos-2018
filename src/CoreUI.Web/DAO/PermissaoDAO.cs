using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class PermissaoDAO
    {

        private readonly ApplicationDbContext _context;

        public PermissaoDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Permissao>> Listar()
        {
            return await _context.Permissoes
                .ToListAsync();
        }

        public async Task Create(Permissao permissao)
        {
            _context.Add(permissao);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(Permissao permissao)
        {
            _context.Remove(permissao);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(Permissao permissao)
        {
            _context.Update(permissao);
            await _context.SaveChangesAsync();
        }

        public async Task<Permissao> GetById(int? id)
        {
            Permissao permissao = await _context.Permissoes
                .AsNoTracking()
                .SingleOrDefaultAsync(p => p.Id == id);
            return permissao;
        }

    }
}

