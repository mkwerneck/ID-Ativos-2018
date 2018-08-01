using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class SetorProprietarioDAO
    {

        private readonly ApplicationDbContext _context;

        public SetorProprietarioDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<SetorProprietario>> Listar()
        {
            return await _context.SetorProprietarios
                .Include(p => p.Empresa)
                .ToListAsync();
        }

        public async Task Create(SetorProprietario setorProprietario)
        {
            _context.Add(setorProprietario);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(SetorProprietario setorProprietario)
        {
            _context.Remove(setorProprietario);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(SetorProprietario setorProprietario)
        {
            _context.Update(setorProprietario);
            await _context.SaveChangesAsync();
        }

        public async Task<SetorProprietario> GetById(int? id)
        {
            SetorProprietario setorProprietario = await _context.SetorProprietarios
                .Include(p => p.Empresa)
                .AsNoTracking()
                .SingleOrDefaultAsync(p => p.Id == id);
            return setorProprietario;
        }

    }
}
