using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class TagidMaterialDAO
    {

        private readonly ApplicationDbContext _context;

        public TagidMaterialDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Posicao>> Listar()
        {
            return await _context.Posicoes.ToListAsync();
        }

        public async Task Create(TAGIDMaterial tagidMaterial)
        {
            _context.Add(tagidMaterial);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(TAGIDMaterial tagidMaterial)
        {
            _context.Remove(tagidMaterial);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(TAGIDMaterial tagidMaterial)
        {
            _context.Update(tagidMaterial);
            await _context.SaveChangesAsync();
        }

    }
}
