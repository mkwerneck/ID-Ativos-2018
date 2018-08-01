using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class PurchaseOrderDAO
    {

        private readonly ApplicationDbContext _context;

        public PurchaseOrderDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<PurchaseOrder>> Listar()
        {
            return await _context
                .PurchaseOrders.ToListAsync();
        }

        public async Task Create(PurchaseOrder purchaseOrder)
        {
            _context.Add(purchaseOrder);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(PurchaseOrder purchaseOrder)
        {
            _context.Remove(purchaseOrder);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(PurchaseOrder purchaseOrder)
        {
            _context.Update(purchaseOrder);
            await _context.SaveChangesAsync();
        }

        public async Task<PurchaseOrder> GetById(int? id)
        {
            PurchaseOrder purchaseOrder = await _context.PurchaseOrders
                .AsNoTracking()
                .SingleOrDefaultAsync(p => p.Id == id);
            return purchaseOrder;
        }

    }
}
