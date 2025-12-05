using Microsoft.Data.SqlClient;
using VFProyect_BACK.Models.RESPONSES;


public interface IDbContextWrapper
{
    Task<List<UsuarioResponse>> ExecuteUsuarioFromSqlRaw(string sql, params SqlParameter[] parameters);
}

