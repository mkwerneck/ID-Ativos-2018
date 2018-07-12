using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class ModeloMateriaisDAO
    {

        private readonly ApplicationDbContext _context;

        public ModeloMateriaisDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Posicao>> Listar()
        {
            return await _context.Posicoes.ToListAsync();
        }

        public async Task Create(ModeloMateriais modeloMateriais)
        {
            _context.Add(modeloMateriais);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(ModeloMateriais modeloMateriais)
        {
            _context.Remove(modeloMateriais);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(ModeloMateriais modeloMateriais)
        {
            _context.Update(modeloMateriais);
            await _context.SaveChangesAsync();
        }

    }
}
