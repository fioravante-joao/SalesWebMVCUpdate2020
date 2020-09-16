using SalesWevMVCAtual.Data;
using SalesWevMVCAtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWevMVCAtual.Services
{
    public class SellerService
    {
        private readonly SalesWevMVCAtualContext _context;

        public SellerService(SalesWevMVCAtualContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
