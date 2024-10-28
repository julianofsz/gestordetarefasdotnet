using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace GestorDeTarefas.Models
{
    public class TarefaContexto : DbContext
    {
        private readonly IConfiguration _configuration;

        public TarefaContexto(DbContextOptions<TarefaContexto> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        public DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Evita reconfigurar o optionsBuilder se já estiver configurado externamente (como no Startup)
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = _configuration.GetConnectionString("MySqlConnection");
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            }

            base.OnConfiguring(optionsBuilder);
        }
    }
}
