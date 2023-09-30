using PersonasAPI.Modelos;

namespace PersonasAPI.Repositorio
{
    public interface IPersonaRepositorio
    {
        Task<List<Personas>> GetPersonas();
        Task<Personas> GetPersonas(int id);
        Task<Personas>CrearOActualizar(Personas personas);
        Task<bool> DeletePersonas(int id);
    }
}
