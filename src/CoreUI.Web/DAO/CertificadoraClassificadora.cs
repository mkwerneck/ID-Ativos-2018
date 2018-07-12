using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class CertificadoraClassificadoraDAO
    {

        private readonly ApplicationDbContext _context;

        public CertificadoraClassificadoraDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Posicao>> Listar()
        {
            return await _context.Posicoes.ToListAsync();
        }

        public async Task Create(CertificadoraClassificadora certificadoraClassificadora)
        {
            _context.Add(certificadoraClassificadora);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(CertificadoraClassificadora certificadoraClassificadora)
        {
            _context.Remove(certificadoraClassificadora);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(CertificadoraClassificadora certificadoraClassificadora)
        {
            _context.Update(certificadoraClassificadora);
            await _context.SaveChangesAsync();
        }

    }
}
