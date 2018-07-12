using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class CadastroEquipmentDAO
    {

        private readonly ApplicationDbContext _context;

        public CadastroEquipmentDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Posicao>> Listar()
        {
            return await _context.Posicoes.ToListAsync();
        }

        public async Task Create(CadastroEquipment cadastroEquipment)
        {
            _context.Add(cadastroEquipment);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(CadastroEquipment cadastroEquipment)
        {
            _context.Remove(cadastroEquipment);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(CadastroEquipment cadastroEquipment)
        {
            _context.Update(cadastroEquipment);
            await _context.SaveChangesAsync();
        }

    }
}
