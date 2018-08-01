using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class EmpresaDAO
    {

        private readonly ApplicationDbContext _context;

        public EmpresaDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Empresa>> Listar()
        {
            return await _context.Empresas.ToListAsync();
        }

        public async Task Create(Empresa empresa)
        {
            _context.Add(empresa);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(Empresa empresa)
        {
            _context.Remove(empresa);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(Empresa empresa)
        {
            _context.Update(empresa);
            await _context.SaveChangesAsync();
        }

        public async Task<Empresa> GetById(int? id)
        {
            Empresa empresa = await _context.Empresas.Where(p => p.Id == id).SingleOrDefaultAsync();
            return empresa;
        }

    }
}
