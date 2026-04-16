using EventosTematicos.Models;
using Microsoft.EntityFrameworkCore;

namespace EventosTematicos.Data;

public class MySqlDbContext : DbContext
{
    public MySqlDbContext(DbContextOptions<MySqlDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Evento> Eventos { get; set; }
}