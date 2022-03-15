using Microsoft.EntityFrameworkCore;

namespace ToDoApi.Models
{
  public class TarefaContext : DbContext
  {
    public TarefaContext(DbContextOptions<TarefaContext> options)
    : base(options)
    { }
    public DbSet<Tarefa> Tarefas { get; set; } = null!;
  }
}
