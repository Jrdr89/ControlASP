
namespace ControlASP.AccesoDatos
{
    using ControlASP.Entidades;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;

    namespace SistemaControl.AccesoDatos
    {
        public class ApplicationDbContext : DbContext
        {
            private readonly IConfiguration _configuration;
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IConfiguration configuration) : base(options)
            {
                _configuration = configuration;
            }

            public DbSet<usuarioModel> Usuarios { get; set; }
            public DbSet<ClientesModel> Clientes { get; set; }
            public DbSet<FacturasVtosPendientesModel> FacturasVtosPendientes { get; }
            public DbSet<PagosACuentaModel> PagosACuenta { get; set; }
            public DbSet<PagosACuentaAboModel> PagosACuentaAbo { get; set; }


            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
                }

            }
        }
    }

}

