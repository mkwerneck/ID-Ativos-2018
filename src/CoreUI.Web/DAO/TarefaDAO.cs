using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class TarefaDAO
    {

        private readonly ApplicationDbContext _context;

        public TarefaDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Posicao>> Listar()
        {
            return await _context.Posicoes.ToListAsync();
        }

        public async Task Create(Tarefa tarefa)
        {
            _context.Add(tarefa);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(Tarefa tarefa)
        {
            _context.Remove(tarefa);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(Tarefa tarefa)
        {
            _context.Update(tarefa);
            await _context.SaveChangesAsync();
        }

    }
}
