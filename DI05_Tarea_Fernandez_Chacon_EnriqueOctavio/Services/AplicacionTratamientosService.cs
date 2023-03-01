using DI05_Modelo.Modelos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DI05_Tarea_Fernandez_Chacon_EnriqueOctavio.Services
{
    public class AplicacionTratamientosService
    {
        private readonly CitasContext _context;

        public AplicacionTratamientosService(CitasContext context)
        {
            _context = context;
        }

        public async Task Add(AplicacionTratamiento aplicacionTratamiento)
        {
            _context.AplicacionTratamientos.Add(aplicacionTratamiento);
            await _context.SaveChangesAsync();
        }

        public async Task Update(AplicacionTratamiento aplicacionTratamiento)
        {
            _context.AplicacionTratamientos.Update(aplicacionTratamiento);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(AplicacionTratamiento aplicacionTratamiento)
        {
            _context.AplicacionTratamientos.Remove(aplicacionTratamiento);
            await _context.SaveChangesAsync();
        }

        public async Task<List<AplicacionTratamiento>> Get()
        {
            return await _context.AplicacionTratamientos.ToListAsync();
        }
    }
}
