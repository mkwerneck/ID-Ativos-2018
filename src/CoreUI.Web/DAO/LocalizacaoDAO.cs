using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class LocalizacaoDAO
    {
        private readonly ApplicationDbContext _context;

        public LocalizacaoDAO(ApplicationDbContext context) {
            _context = context;
        }

        public async Task<ICollection<Localizacao>> Listar() {
            return await _context.Localizacoes.ToListAsync();
        }

        public async Task<Localizacao> GetItemById(int id) {
            var localizacao = await _context.Localizacoes.Where(p => p.Id == id).SingleOrDefaultAsync();
            return localizacao;
        }

        public async Task Create(Localizacao localizacao) {
            _context.Localizacoes.Add(localizacao);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Localizacao localizacao) {
            _context.Localizacoes.Remove(localizacao);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Localizacao localizacao) {
            _context.Localizacoes.Update(localizacao);
            await _context.SaveChangesAsync();
        }
    }
}
