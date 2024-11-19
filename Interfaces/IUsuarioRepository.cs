using Persistencia.DTOS;

namespace Persistencia.Interface
{
    public interface IUsuarioRepository
    {
        Task<List<Usuario>> GetAllUsuariosAsync();
        Task<Usuario> GetUsuarioByIdAsync(int id);
        Task CreateUsuarioAsync(Usuario Usuario);
        Task<bool> UpdateUsuarioAsync(Usuario Usuario);
        Task<bool> DeleteUsuarioAsync(int id);
    }
}