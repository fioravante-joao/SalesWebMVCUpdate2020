using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWevMVCAtual.Models;

namespace SalesWevMVCAtual.Data
{
    public class SalesWevMVCAtualContext : DbContext
    {
        public SalesWevMVCAtualContext (DbContextOptions<SalesWevMVCAtualContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWevMVCAtual.Models.Department> Department { get; set; }
    }
}
