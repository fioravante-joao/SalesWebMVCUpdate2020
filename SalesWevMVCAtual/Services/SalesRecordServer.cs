using SalesWevMVCAtual.Data;
using SalesWevMVCAtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWevMVCAtual.Services
{
    public class SalesRecordServer
    {
        private readonly SalesWevMVCAtualContext _context;    //Dependência do Contexto

        public SalesRecordServer(SalesWevMVCAtualContext context)  //construtor
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }

            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .ToListAsync(); 
        }
    }
}
