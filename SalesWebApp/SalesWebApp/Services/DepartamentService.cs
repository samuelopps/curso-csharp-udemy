using Microsoft.EntityFrameworkCore;
using SalesWebApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebApp.Services
{
    public class DepartamentService
    {
        private readonly SalesWebAppContext _context;

        public DepartamentService(SalesWebAppContext context)
        {
            _context = context;
        }

        public async Task<List<Departament>> FindAllAsync()
        {
            return await _context.Departament.OrderBy(x => x.Name)
                .ToListAsync();
        }
    }
}
