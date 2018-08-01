using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class RequisicaoDAO
    {

        private readonly ApplicationDbContext _context;

        public RequisicaoDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Requisicao>> Listar()
        {
            return await _context.Requisicoes.ToListAsync();
        }

        public async Task Create(Requisicao requisicao)
        {
            _context.Add(requisicao);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(Requisicao requisicao)
        {
            _context.Remove(requisicao);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(Requisicao requisicao)
        {
            _context.Update(requisicao);
            await _context.SaveChangesAsync();
        }

        public async Task<Requisicao> GetById(int? id)
        {
            Requisicao requisicao = await _context.Requisicoes
                .AsNoTracking()
                .SingleOrDefaultAsync(p => p.Id == id);
            return requisicao;
        }

    }
}
