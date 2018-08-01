using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class CadastroMateriaisDAO
    {

        private readonly ApplicationDbContext _context;

        public CadastroMateriaisDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Posicao>> Listar()
        {
            return await _context.Posicoes.ToListAsync();
        }

        public async Task Create(CadastroMateriais cadastroMateriais)
        {
            _context.Add(cadastroMateriais);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(CadastroMateriais cadastroMateriais)
        {
            _context.Remove(cadastroMateriais);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(CadastroMateriais cadastroMateriais)
        {
            _context.Update(cadastroMateriais);
            await _context.SaveChangesAsync();
        }

    }
}
