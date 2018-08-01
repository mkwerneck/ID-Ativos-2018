using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class GPSIDEquipmentDAO
    {

        private readonly ApplicationDbContext _context;

        public GPSIDEquipmentDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<GPSIDEquipment>> Listar()
        {
            return await _context.GPSIDEquipamentos
                .ToListAsync();
        }

        public async Task Create(GPSIDEquipment gpsidEquipment)
        {
            _context.Add(gpsidEquipment);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(GPSIDEquipment gpsidEquipment)
        {
            _context.Remove(gpsidEquipment);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(GPSIDEquipment gpsidEquipment)
        {
            _context.Update(gpsidEquipment);
            await _context.SaveChangesAsync();
        }

        public async Task<GPSIDEquipment> GetById(int? id)
        {
            GPSIDEquipment gpsidEquipment = await _context.GPSIDEquipamentos
                .AsNoTracking()
                .SingleOrDefaultAsync(p => p.Id == id);
            return gpsidEquipment;
        }

    }
}
