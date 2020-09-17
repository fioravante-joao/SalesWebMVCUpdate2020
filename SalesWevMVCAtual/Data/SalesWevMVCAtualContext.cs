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
        public SalesWevMVCAtualContext()  //Construtor sem argumentos
        {
        }

        public SalesWevMVCAtualContext (DbContextOptions<SalesWevMVCAtualContext> options) //Construtor com argumentos
            : base(options)
        {
        }

        //public DbSet<SalesWevMVCAtual.Models.Department> Department { get; set; }  outra maneira de conectar a minha tabela na base de dados.
        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }

    }
}
