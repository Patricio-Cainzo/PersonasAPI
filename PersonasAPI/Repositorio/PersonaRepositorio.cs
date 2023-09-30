using Microsoft.EntityFrameworkCore;
using PersonasAPI.Data;
using PersonasAPI.Modelos;
using PersonasAPI.Repositorio;

namespace PersonasAPI.Repositorios
{
    public class PersonaRepositorio : IPersonaRepositorio
    {
        private readonly DataContext _context;

        public Task<Personas> CrearOActualizar(Personas personas)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePersonas(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Personas>> GetPersonas()
        {
            List<Personas>persona = await _context.Personas.ToListAsync();
            return persona;
        }

        public Task<Personas> GetPersonas(int id)
        {
            throw new NotImplementedException();
        }
    }
}
