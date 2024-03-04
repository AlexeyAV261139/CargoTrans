using DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace DB;

public partial class CargosDbContext : DbContext
{
    public CargosDbContext()
    {
        Database.EnsureCreated();
    }

    public CargosDbContext(DbContextOptions<CargosDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ActiveRoute> ActiveRoutes { get; set; }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<Cargo> Cargos { get; set; }

    public virtual DbSet<CargoType> CargoTypes { get; set; }

    public virtual DbSet<Driver> Drivers { get; set; }

    public virtual DbSet<Route> Routes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=CargosDB;Username=postgres;Password=qwerty");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ActiveRoute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("active_routes_pkey");

            entity.ToTable("active_routes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.CargoId).HasColumnName("cargo_id");
            entity.Property(e => e.DriverId).HasColumnName("driver_id");
            entity.Property(e => e.EndTime).HasColumnName("end_time");
            entity.Property(e => e.RouteId).HasColumnName("route_id");

            entity.HasOne(d => d.Car).WithMany(p => p.ActiveRoutes)
                .HasForeignKey(d => d.CarId)
                .HasConstraintName("active_routes_car_id_fkey");

            entity.HasOne(d => d.Cargo).WithMany(p => p.ActiveRoutes)
                .HasForeignKey(d => d.CargoId)
                .HasConstraintName("active_routes_cargo_id_fkey");

            entity.HasOne(d => d.Driver).WithMany(p => p.ActiveRoutes)
                .HasForeignKey(d => d.DriverId)
                .HasConstraintName("active_routes_driver_id_fkey");

            entity.HasOne(d => d.Route).WithMany(p => p.ActiveRoutes)
                .HasForeignKey(d => d.RouteId)
                .HasConstraintName("active_routes_route_id_fkey");
        });

        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cars_pkey");

            entity.ToTable("cars");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Brand)
                .HasMaxLength(30)
                .HasColumnName("brand");
            entity.Property(e => e.LoadCapacityPerKg).HasColumnName("load_capacity_per_kg");
            entity.Property(e => e.Number)
                .HasMaxLength(10)
                .HasColumnName("number");
        });

        modelBuilder.Entity<Cargo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cargos_pkey");

            entity.ToTable("cargos");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CargoTypeId).HasColumnName("cargo_type_id");
            entity.Property(e => e.Requirements)
                .HasMaxLength(100)
                .HasColumnName("requirements");

            entity.HasOne(d => d.CargoType).WithMany(p => p.Cargos)
                .HasForeignKey(d => d.CargoTypeId)
                .HasConstraintName("cargos_cargo_type_id_fkey");
        });

        modelBuilder.Entity<CargoType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cargo_types_pkey");

            entity.ToTable("cargo_types");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Driver>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("drivers_pkey");

            entity.ToTable("drivers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
            entity.Property(e => e.Phone).HasColumnName("phone");
        });

        modelBuilder.Entity<Route>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("routes_pkey");

            entity.ToTable("routes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Destination)
                .HasMaxLength(40)
                .HasColumnName("destination");
            entity.Property(e => e.DistancvePerKm).HasColumnName("distancve_per_km");
            entity.Property(e => e.PricePerPenny).HasColumnName("price_per_penny");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
