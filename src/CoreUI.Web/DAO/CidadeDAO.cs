using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class CidadeDAO
    {

        private readonly ApplicationDbContext _context;

        public CidadeDAO(ApplicationDbContext context) {
            _context = context;
        }

        public async Task<ICollection<Cidade>> Listar() {
            return await _context.Cidades.ToListAsync();
        }

        public async Task Create(Cidade cidade)
        {
            _context.Add(cidade);
            await _context.SaveChangesAsync();
        }
    }
}
