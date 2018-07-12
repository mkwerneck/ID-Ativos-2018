using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class TAGIDEquipmentDAO
    {

        private readonly ApplicationDbContext _context;

        public TAGIDEquipmentDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Posicao>> Listar()
        {
            return await _context.Posicoes.ToListAsync();
        }

        public async Task Create(TAGIDEquipment tAGIDEquipment)
        {
            _context.Add(tAGIDEquipment);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(TAGIDEquipment tAGIDEquipment)
        {
            _context.Remove(tAGIDEquipment);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(TAGIDEquipment tAGIDEquipment)
        {
            _context.Update(tAGIDEquipment);
            await _context.SaveChangesAsync();
        }

    }
}
