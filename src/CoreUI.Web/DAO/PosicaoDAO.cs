using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class PosicaoDAO
    {
        private readonly ApplicationDbContext _context;

        public PosicaoDAO(ApplicationDbContext context) {
            _context = context;
        }

        public async Task<ICollection<Posicao>> Listar() {
            return await _context.Posicoes
                .Include(p => p.Almoxarifado)
                .ToListAsync();
        }

        public async Task<Posicao> GetItemById(int id) {
            var posicao = await _context.Posicoes.Where(p => p.Id == id)
                .SingleOrDefaultAsync();
            return posicao;
        }

        public async Task Create(Posicao posicao) {
            _context.Posicoes.Add(posicao);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Posicao posicao) {
            _context.Posicoes.Remove(posicao);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Posicao posicao) {
            _context.Posicoes.Update(posicao);
            await _context.SaveChangesAsync();
        }
    }
}
