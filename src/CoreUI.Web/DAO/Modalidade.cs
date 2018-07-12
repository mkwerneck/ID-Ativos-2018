using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class ModalidadeDAO
    {

        private readonly ApplicationDbContext _context;

        public ModalidadeDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Posicao>> Listar()
        {
            return await _context.Posicoes.ToListAsync();
        }

        public async Task Create(Modalidade modalidade)
        {
            _context.Add(modalidade);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(Modalidade modalidade)
        {
            _context.Remove(modalidade);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(Modalidade modalidade)
        {
            _context.Update(modalidade);
            await _context.SaveChangesAsync();
        }

    }
}
