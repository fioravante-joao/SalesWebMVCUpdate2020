using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWevMVCAtual.Models;
using SalesWevMVCAtual.Models.Enums;

namespace SalesWevMVCAtual.Data
{
    public class SeedingService
    {
        private SalesWevMVCAtualContext _context;

        public SeedingService(SalesWevMVCAtualContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return;  //o banco de dados já foi populado.
            }

            Department d1 = new Department(1,"Computers");
            Department d2 = new Department(2, "Electronics");

            Seller s1 = new Seller(1, "joao", "joao@gmail.com", 1000.0, new DateTime(1994, 12, 27), d1);
            Seller s2 = new Seller(2, "lucao", "lucao@gmail.com", 1000.0, new DateTime(1994, 12, 27), d2);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s2);

            _context.Department.AddRange(d1, d2);
            _context.Seller.AddRange(s1, s2);
            _context.SalesRecord.AddRange(r1, r2);

            _context.SaveChanges();
        }
    }
}
