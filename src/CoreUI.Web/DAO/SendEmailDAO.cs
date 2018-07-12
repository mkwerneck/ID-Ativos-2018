﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreUI.Web.Data;
using CoreUI.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreUI.Web.DAO
{
    public class SendEmailDAO
    {

        private readonly ApplicationDbContext _context;

        public SendEmailDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Posicao>> Listar()
        {
            return await _context.Posicoes.ToListAsync();
        }

        public async Task Create(SendEmail sendEmail)
        {
            _context.Add(sendEmail);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(SendEmail sendEmail)
        {
            _context.Remove(sendEmail);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(SendEmail sendEmail)
        {
            _context.Update(sendEmail);
            await _context.SaveChangesAsync();
        }

    }
}
