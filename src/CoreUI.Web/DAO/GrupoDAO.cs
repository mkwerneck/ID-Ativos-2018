using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class GrupoDAO
    {

        private readonly ApplicationDbContext _context;

        public GrupoDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Posicao>> Listar()
        {
            return await _context.Posicoes.ToListAsync();
        }

        public async Task Create(Grupo grupo)
        {
            _context.Add(grupo);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(Grupo grupo)
        {
            _context.Remove(grupo);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(Grupo grupo)
        {
            _context.Update(grupo);
            await _context.SaveChangesAsync();
        }

    }
}
