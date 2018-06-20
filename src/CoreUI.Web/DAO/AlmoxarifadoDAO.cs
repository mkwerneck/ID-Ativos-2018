using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class AlmoxarifadoDAO
    {

        private readonly ApplicationDbContext _context;

        public AlmoxarifadoDAO(ApplicationDbContext context) {
            _context = context;
        }

        public async Task<ICollection<Almoxarifado>> Listar() {
            return await _context.Almoxarifados.ToListAsync();
        }

        public async Task<Almoxarifado> GetItemByid(int id) {
            var almoxarifado = await _context.Almoxarifados.Where(p => p.Id == id).SingleOrDefaultAsync();
            return almoxarifado;
        }

        public async Task Create(Almoxarifado almoxarifado) {
            _context.Almoxarifados.Add(almoxarifado);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Almoxarifado almoxarifado)
        {
            _context.Almoxarifados.Remove(almoxarifado);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Almoxarifado almoxarifado) {
            _context.Almoxarifados.Update(almoxarifado);
            await _context.SaveChangesAsync();
        }
    }
}
