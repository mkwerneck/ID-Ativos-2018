using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class ServicoAdicionalDAO
    {

        private readonly ApplicationDbContext _context;

        public ServicoAdicionalDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Posicao>> Listar()
        {
            return await _context.Posicoes.ToListAsync();
        }

        public async Task Create(ServicoAdicional servicoAdicional)
        {
            _context.Add(servicoAdicional);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(ServicoAdicional servicoAdicional)
        {
            _context.Remove(servicoAdicional);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(ServicoAdicional servicoAdicional)
        {
            _context.Update(servicoAdicional);
            await _context.SaveChangesAsync();
        }

    }
}
