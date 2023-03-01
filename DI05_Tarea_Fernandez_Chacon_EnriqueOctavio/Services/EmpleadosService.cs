using DI05_Modelo.Modelos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DI05_Tarea_Fernandez_Chacon_EnriqueOctavio.Services
{
    public class EmpleadosService
    {
        private readonly CitasContext _context;

        public EmpleadosService(CitasContext context)
        {
            _context = context;
        }

        public async Task Add(Empleado empleado)
        {
            _context.Empleados.Add(empleado);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Empleado empleado)
        {
            _context.Empleados.Update(empleado);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Empleado empleado)
        {
            _context.Empleados.Remove(empleado);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Empleado>> Get()
        {
            return await _context.Empleados.ToListAsync();
        }
    }
}
