using SalesWevMVCAtual.Data;
using SalesWevMVCAtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWevMVCAtual.Services
{
    public class DepartmentService
    {
        private readonly SalesWevMVCAtualContext _context;    //Dependência do Contexto

        public DepartmentService(SalesWevMVCAtualContext context)  //construtor
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            //return _context.Department.ToList();
            return _context.Department.OrderBy(x => x.Name).ToList();    //Lista ordenada por nome
        }
    }
}
