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

        public async Task<ICollection<Documentacao>> Listar()
        {
            return await _context.Documentacoes.ToListAsync();
        }

        //voltar para asincrono apos testes
        public async Task <Documentacao> GetItemById(int id)
        {
            return await _context.Documentacoes.Where(p => p.Id == id).SingleAsync();
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
