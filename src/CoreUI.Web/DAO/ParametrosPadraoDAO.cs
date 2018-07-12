using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class ParametrosPadraoDAO
    {

        private readonly ApplicationDbContext _context;

        public ParametrosPadraoDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Posicao>> Listar()
        {
            return await _context.Posicoes.ToListAsync();
        }

        public async Task Create(ParametrosPadrao parametrosPadrao)
        {
            _context.Add(parametrosPadrao);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(ParametrosPadrao parametrosPadrao)
        {
            _context.Remove(parametrosPadrao);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(ParametrosPadrao parametrosPadrao)
        {
            _context.Update(parametrosPadrao);
            await _context.SaveChangesAsync();
        }

    }
}
