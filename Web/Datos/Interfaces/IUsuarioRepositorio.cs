using Modelos;

namespace Datos.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<bool> NuevoUsuarioAsync(Usuario user);
        Task<bool> ActualizarAsync(Usuario user);
        Task<bool> EliminarAsync(string codigoUsuario);
        Task<IEnumerable<Usuario>> GetListaAsync();
        Task<Usuario> GetPorCodigoAsync(string codigoUsuario);
    }
}
