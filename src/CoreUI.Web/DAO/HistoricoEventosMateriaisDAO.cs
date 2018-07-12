using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class HistoricoEventosMateriaisDAO
    {

        private readonly ApplicationDbContext _context;

        public HistoricoEventosMateriaisDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Posicao>> Listar()
        {
            return await _context.Posicoes.ToListAsync();
        }

        public async Task Create(HistoricoEventosMateriais historicoEventosMateriais)
        {
            _context.Add(historicoEventosMateriais);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(HistoricoEventosMateriais historicoEventosMateriais)
        {
            _context.Remove(historicoEventosMateriais);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(HistoricoEventosMateriais historicoEventosMateriais)
        {
            _context.Update(historicoEventosMateriais);
            await _context.SaveChangesAsync();
        }

    }
}
