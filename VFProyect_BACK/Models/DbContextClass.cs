using Microsoft.EntityFrameworkCore;
using VFProyect_BACK.Models.RESPONSES;

namespace VFProyect_BACK.Models
{
    public class DbContextClass: DbContext
    {
        protected readonly IConfiguration Configuration;

        public DbContextClass(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
        public virtual  DbSet<UsuarioResponse> Usuario { get; set; }
        public virtual  DbSet<ClienteResponse> Cliente { get; set; }
        public virtual  DbSet<EntrenadorResponse> Entrenador { get; set; }
        public virtual  DbSet<ClaseResponse> Clase { get; set; }

    }
}
