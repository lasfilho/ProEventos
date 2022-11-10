using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence.Contratos
{
    public interface IPalestrantePersist
    {        
        Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includeEventos); 
        Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos); 
        Task<Palestrante> GetPalestrantesByIdAsync(int palestranteId, bool includeEventos); 
    }
}