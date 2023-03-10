using DI05_Modelo.Modelos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DI05_Tarea_Fernandez_Chacon_EnriqueOctavio.Services
{
    public class ClinicaService
    {
        private readonly ClinicaContext _context;

        public ClinicaService(ClinicaContext context)
        {
            _context = context;
        }

        public async Task Add(Cita cita)
        {
            _context.Citas.Add(cita);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Cita cita)
        {
            _context.Citas.Update(cita);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Cita cita)
        {
            _context.Citas.Remove(cita);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Cita>> Get()
        {
            return await _context.Citas.ToListAsync();
        }
    }
}
