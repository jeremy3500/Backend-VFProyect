using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using VFProyect_BACK.Models;
using VFProyect_BACK.Models.RESPONSES;
using VFProyect_BACK.Models.REQUESTS;

namespace VFProyect_BACK.Repositories
{


    public class UsuarioService : IUsuarioService
    {
        private readonly DbContextClass _dbContext;
        public UsuarioService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<ClienteResponse>> GetClientes()
        {
            return await _dbContext.Cliente
                .FromSqlRaw("sp_VerClientes")
            .ToListAsync();
        }

        public async Task<List<EntrenadorResponse>> GetEntrenadores ()
        {
            return await _dbContext.Entrenador
                .FromSqlRaw("sp_VerEntrenadores")
            .ToListAsync();
        }

        public async Task<List<ClaseResponse>> GetClases()
        {
            return await _dbContext.Clase
                .FromSqlRaw("sp_VerClases")
            .ToListAsync();
        }

        public async Task<IEnumerable<UsuarioResponse>> GetUsuarioByIdAsync(int CLIENTE_ID)
        {
            var PARAMETER = new SqlParameter("@ID_CLIENTE", CLIENTE_ID);

            var USER_DETAILS = await Task.Run(() => _dbContext.Usuario
                .FromSqlRaw(@"EXEC sp_ObtenerClasesPorCliente @ID_CLIENTE", PARAMETER).ToListAsync());
            return USER_DETAILS;
        }

        public async Task<List<UsuarioResponse>> Login(LoginUserRequest USUARIO)
        {
            var PARAMETERS = new List<SqlParameter>
            {
                new SqlParameter("@EMAIL", USUARIO.EMAIL),
                new SqlParameter("@PASSWORDS", USUARIO.PASSWORD)
            };

            return await _dbContext.Usuario
                .FromSqlRaw(@"EXEC SP_LoggerUsuario @EMAIL, @PASSWORDS", PARAMETERS.ToArray())
            .ToListAsync();
        }
    }
}
