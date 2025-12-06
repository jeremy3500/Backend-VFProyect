using VFProyect_BACK.Models.RESPONSES;
using VFProyect_BACK.Models.REQUESTS;

namespace VFProyect_BACK.Repositories
{
    public interface IUsuarioService
    {
        public Task<List<ClienteResponse>> GetClientes();
        public Task<List<EntrenadorResponse>> GetEntrenadores();
        public Task<List<ClaseResponse>> GetClases();
        public Task<IEnumerable<UsuarioResponse>> GetUsuarioByIdAsync(int UsuarioId);
        public Task<List<UsuarioResponse>> Login(LoginUserRequest usuario);
        public Task<List<EntrenadorResponse>> InsertEntrenador(EntrenadorRequest ENTRENADOR);
        public Task<List<ClienteResponse>> InsertCliente(ClienteRequest CLIENTE);

    }
}
