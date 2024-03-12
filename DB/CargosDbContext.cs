using DataAccess.Postgres.Models;
using Microsoft.EntityFrameworkCore;

namespace DB;

public class CargosDbContext(DbContextOptions<CargosDbContext> options)
       : DbContext(options)
{
    public DbSet<CarEntity> Cars { get; set; }

    public DbSet<CargoEntity> Cargos { get; set; }

    public DbSet<DriverEntity> Drivers { get; set; }

    public DbSet<FlightEntity> Flights { get; set; }

    public DbSet<PathEntity> Paths { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {       
        base.OnModelCreating(modelBuilder);
    }
}
