using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class DocumentacaoDAO
    {

        private readonly ApplicationDbContext _context;

        public DocumentacaoDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Posicao>> Listar()
        {
            return await _context.Posicoes.ToListAsync();
        }

        public async Task Create(Documentacao documentacao)
        {
            _context.Add(documentacao);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(Documentacao documentacao)
        {
            _context.Remove(documentacao);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(Documentacao documentacao)
        {
            _context.Update(documentacao);
            await _context.SaveChangesAsync();
        }

    }
}
