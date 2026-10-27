using Microsoft.EntityFrameworkCore;
using TicketApi.Models;

namespace TicketApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users => Set<User>();
    public DbSet<Role> Roles => Set<Role>();
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Ticket> Tickets => Set<Ticket>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Insertar datos iniciales
        modelBuilder.Entity<Role>().HasData(
            new Role { Id = 1, Name = "Admin" },
            new Role { Id = 2, Name = "Tecnico" },
            new Role { Id = 3, Name = "Usuario" }
        );

        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Hardware" },
            new Category { Id = 2, Name = "Software / Sistemas" },
            new Category { Id = 3, Name = "Redes" }
        );
    }
}