using DI05_Modelo.Modelos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DI05_Tarea_Fernandez_Chacon_EnriqueOctavio.Services
{
    public class TratamientosService
    {
        private readonly CitasContext _context;

        public TratamientosService(CitasContext context)
        {
            _context = context;
        }

        public async Task Add(Tratamiento tratamiento)
        {
            _context.Tratamientos.Add(tratamiento);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Tratamiento tratamiento)
        {
            _context.Tratamientos.Update(tratamiento);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Tratamiento tratamiento)
        {
            _context.Tratamientos.Remove(tratamiento);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Tratamiento>> Get()
        {
            return await _context.Tratamientos.ToListAsync();
        }
    }
}
