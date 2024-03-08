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
            entity.Property(e => e.Size)
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

        FillBD(modelBuilder);
    }

    private void FillBD(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>().HasData(new[]
        {
            new Car { Id = 1, Brand = "BMW", Number = "A123BB", LoadCapacityPerKg = 1000 },
            new Car { Id = 2, Brand = "BMW", Number = "A123BC", LoadCapacityPerKg = 500},
            new Car { Id = 3, Brand = "Mercedes-Benz", Number = "B222BK", LoadCapacityPerKg = 500},
            new Car { Id = 4, Brand = "Lada", Number = "K234OM", LoadCapacityPerKg = 600}
        });

        modelBuilder.Entity<CargoType>().HasData(new[]
        {
            new CargoType { Id = 1, Size = "Большой"},
            new CargoType { Id = 2, Size = "Средний"},
            new CargoType { Id = 3, Size = "Большой"},
            new CargoType { Id = 4, Size = "Маленький"}
        });

        modelBuilder.Entity<Cargo>().HasData(new[]
        {
            new Cargo { Id = 1, CargoTypeId = 1, Requirements = "Не ставить друг на друга"},
            new Cargo { Id = 2, CargoTypeId = 3, Requirements = "Не переворачивать"},
            new Cargo { Id = 3, CargoTypeId = 4, Requirements = ""}
        });

        modelBuilder.Entity<Driver>().HasData(new[]
        {
            new Driver { Id = 1, FirstName = "Алексей", LastName = "Соколов", Phone = "89516918858"},
            new Driver { Id = 2, FirstName = "Артем", LastName = "Петров", Phone = "89091234323"},
            new Driver { Id = 3, FirstName = "Мирон", LastName = "Кулишов", Phone = "88005553535"},
            new Driver { Id = 4, FirstName = "Сергей", LastName = "Лавров", Phone = "89005432324"}
        });

        modelBuilder.Entity<Route>().HasData(new[]
        {
            new Route { Id = 1, Destination = "Ул. Николаева, д 27", DistancvePerKm = 13, PricePerPenny = 156723},
            new Route { Id = 2, Destination = "Ул. Кирова, д 96", DistancvePerKm = 30, PricePerPenny = 240000},
            new Route { Id = 3,Destination = "Ул. Попова, д 100", DistancvePerKm = 8, PricePerPenny = 60050},
            new Route { Id = 4,Destination = "Ул. 25 сентября, д 7", DistancvePerKm = 24, PricePerPenny = 209008}
        });
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
