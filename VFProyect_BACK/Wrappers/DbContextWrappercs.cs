using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using VFProyect_BACK.Models;
using VFProyect_BACK.Models.RESPONSES;

public class DbContextWrapper : IDbContextWrapper
{
    private readonly DbContextClass _context;

    public DbContextWrapper(DbContextClass context)
    {
        _context = context;
    }

    public async Task<List<UsuarioResponse>> ExecuteUsuarioFromSqlRaw(string sql, params SqlParameter[] parameters)
    {
        return await _context.Usuario.FromSqlRaw(sql, parameters).ToListAsync();
    }

}

