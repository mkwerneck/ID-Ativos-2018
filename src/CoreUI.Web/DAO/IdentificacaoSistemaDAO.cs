using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class IdentificacaoSistemaDAO
    {

        private readonly ApplicationDbContext _context;

        public IdentificacaoSistemaDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<IdentificacaoSistema>> Listar()
        {
            return await _context.IdentificacaoSistemas
                .Include(p => p.Localizacao)
                .ToListAsync();
        }

        public async Task Create(IdentificacaoSistema identificacaoSistema)
        {
            _context.Add(identificacaoSistema);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(IdentificacaoSistema identificacaoSistema)
        {
            _context.Remove(identificacaoSistema);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(IdentificacaoSistema identificacaoSistema)
        {
            _context.Update(identificacaoSistema);
            await _context.SaveChangesAsync();
        }

        public async Task<IdentificacaoSistema> GetById(int? id)
        {
            IdentificacaoSistema identificacaoSistema = await _context.IdentificacaoSistemas
                .Include(p => p.Localizacao)
                .AsNoTracking()
                .SingleOrDefaultAsync(p => p.Id == id);
            return identificacaoSistema;
        }
    }
}
