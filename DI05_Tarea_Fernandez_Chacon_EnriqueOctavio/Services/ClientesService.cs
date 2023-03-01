using DI05_Modelo.Modelos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DI05_Tarea_Fernandez_Chacon_EnriqueOctavio.Services
{
    public class ClientesService
    {
        private readonly CitasContext _context;

        public ClientesService(CitasContext context)
        {
            _context = context;
        }

        public async Task Add(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Cliente cliente)
        {
            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Cliente>> Get()
        {
            return await _context.Clientes.ToListAsync();
        }
    }
}
