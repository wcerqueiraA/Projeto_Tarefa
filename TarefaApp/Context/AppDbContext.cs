using Microsoft.EntityFrameworkCore;
using TarefaApp.Models;

namespace TarefaApp.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Tarefa> Tarefas { get; set; }
    }
}
