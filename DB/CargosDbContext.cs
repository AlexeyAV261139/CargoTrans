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

    public virtual DbSet<ActiveRouteEntity> ActiveRoutes { get; set; }

    public virtual DbSet<CarEntity> Cars { get; set; }

    public virtual DbSet<CargoEntity> Cargos { get; set; }

    public virtual DbSet<CargoTypeEntity> CargoTypes { get; set; }

    public virtual DbSet<DriverEntity> Drivers { get; set; }

    public virtual DbSet<RouteEntity> Routes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=CargosDB;Username=postgres;Password=qwerty");
        optionsBuilder.LogTo(message => System.Diagnostics.Debug.WriteLine(message));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {       
        modelBuilder.Entity<ActiveRouteEntity>(entity =>
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

        modelBuilder.Entity<CarEntity>(entity =>
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

        modelBuilder.Entity<CargoEntity>(entity =>
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

        modelBuilder.Entity<CargoTypeEntity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cargo_types_pkey");

            entity.ToTable("cargo_types");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
        });

        modelBuilder.Entity<DriverEntity>(entity =>
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

        modelBuilder.Entity<RouteEntity>(entity =>
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

        FillBD(modelBuilder);
    }

    private void FillBD(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CarEntity>().HasData(new[]
        {
            new CarEntity { Id = 1, Brand = "BMW", Number = "A123BB", LoadCapacityPerKg = 1000 },
            new CarEntity { Id = 2, Brand = "BMW", Number = "A123BC", LoadCapacityPerKg = 500},
            new CarEntity { Id = 3, Brand = "Mercedes-Benz", Number = "B222BK", LoadCapacityPerKg = 500},
            new CarEntity { Id = 4, Brand = "Lada", Number = "K234OM", LoadCapacityPerKg = 600}
        });

        modelBuilder.Entity<CargoTypeEntity>().HasData(new[]
        {
            new CargoTypeEntity { Id = 1, Name = "Большой"},
            new CargoTypeEntity { Id = 2, Name = "Средний"},
            new CargoTypeEntity { Id = 3, Name = "Большой"},
            new CargoTypeEntity { Id = 4, Name = "Маленький"}
        });

        modelBuilder.Entity<CargoEntity>().HasData(new[]
        {
            new CargoEntity { Id = 1, CargoTypeId = 1, Requirements = "Не ставить друг на друга"},
            new CargoEntity { Id = 2, CargoTypeId = 3, Requirements = "Не переворачивать"},
            new CargoEntity { Id = 3, CargoTypeId = 4, Requirements = ""}
        });

        modelBuilder.Entity<DriverEntity>().HasData(new[]
        {
            new DriverEntity { Id = 1, FirstName = "Алексей", LastName = "Соколов", Phone = "89516918858"},
            new DriverEntity { Id = 2, FirstName = "Артем", LastName = "Петров", Phone = "89091234323"},
            new DriverEntity { Id = 3, FirstName = "Мирон", LastName = "Кулишов", Phone = "88005553535"},
            new DriverEntity { Id = 4, FirstName = "Сергей", LastName = "Лавров", Phone = "89005432324"}
        });

        modelBuilder.Entity<RouteEntity>().HasData(new[]
        {
            new RouteEntity { Id = 1, Destination = "Ул. Николаева, д 27", DistancvePerKm = 13, PricePerPenny = 156723},
            new RouteEntity { Id = 2, Destination = "Ул. Кирова, д 96", DistancvePerKm = 30, PricePerPenny = 240000},
            new RouteEntity { Id = 3,Destination = "Ул. Попова, д 100", DistancvePerKm = 8, PricePerPenny = 60050},
            new RouteEntity { Id = 4,Destination = "Ул. 25 сентября, д 7", DistancvePerKm = 24, PricePerPenny = 209008}
        });
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
