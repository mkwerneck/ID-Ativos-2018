using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class TAGIDPosicaoDAO
    {

        private readonly ApplicationDbContext _context;

        public TAGIDPosicaoDAO(ApplicationDbContext context) {
            _context = context;
        }

        public async Task<ICollection<TAGIDPosicao>> Listar() {

            return await _context.TAGIDsPosicao.ToListAsync();

        }

        public async Task<TAGIDPosicao> GetItemById(int id) {
            var tagidPosicao = await _context.TAGIDsPosicao.Where(p => p.Id == id).SingleOrDefaultAsync();
            return tagidPosicao;

        }

        public async Task Create(TAGIDPosicao tagidPosicao) {
            _context.TAGIDsPosicao.Add(tagidPosicao);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(TAGIDPosicao tagidPosicao) {
            _context.TAGIDsPosicao.Remove(tagidPosicao);
            await _context.SaveChangesAsync();
        }

        public async Task Update(TAGIDPosicao tagidPosicao) {
            _context.TAGIDsPosicao.Update(tagidPosicao);
            await _context.SaveChangesAsync();
        }
    }
}
