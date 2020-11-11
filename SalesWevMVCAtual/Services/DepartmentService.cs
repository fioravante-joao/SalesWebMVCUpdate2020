using SalesWevMVCAtual.Data;
using SalesWevMVCAtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWevMVCAtual.Services
{
    public class DepartmentService
    {
        private readonly SalesWevMVCAtualContext _context;    //Dependência do Contexto

        public DepartmentService(SalesWevMVCAtualContext context)  //construtor
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            //return _context.Department.ToList();
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();    //Lista ordenada por nome
        }
    }
}
