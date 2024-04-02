using DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace DB;

public partial class CargosDbContext : DbContext
{
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
        AddDefaultData(modelBuilder);
    }

    private void AddDefaultData(ModelBuilder modelBuilder)
    {
        var cargoTypes = new[]
        {
            new CargoTypeEntity { Name = "Большой"},
            new CargoTypeEntity { Name = "Средний"},
            new CargoTypeEntity { Name = "Большой"},
            new CargoTypeEntity { Name = "Маленький"}
        };
        CreateCars(modelBuilder);
        CreateTypes(modelBuilder, cargoTypes);
        CreateCargos(modelBuilder, cargoTypes);
        CreateDrivers(modelBuilder);
        CreateRoutes(modelBuilder);
    }

    private static void CreateRoutes(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RouteEntity>().HasData(
        [
            new RouteEntity { Destination = "Ул. Николаева, д 27", DistancePerKm = 13, Price = 156723},
            new RouteEntity { Destination = "Ул. Кирова, д 96", DistancePerKm = 30, Price = 240000},
            new RouteEntity { Destination = "Ул. Попова, д 100", DistancePerKm = 8, Price = 60050},
            new RouteEntity { Destination = "Ул. 25 сентября, д 7", DistancePerKm = 24, Price = 209008}
        ]);
    }

    private static void CreateDrivers(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DriverEntity>().HasData(
        [
            new DriverEntity {  FirstName = "Алексей", LastName = "Соколов", Phone = "89516918858"},
            new DriverEntity {  FirstName = "Артем", LastName = "Петров", Phone = "89091234323"},
            new DriverEntity {  FirstName = "Мирон", LastName = "Кулишов", Phone = "88005553535"},
            new DriverEntity {  FirstName = "Сергей", LastName = "Лавров", Phone = "89005432324"}
        ]);
    }

    private static void CreateCargos(ModelBuilder modelBuilder, CargoTypeEntity[] cargoTypes)
    {
        modelBuilder.Entity<CargoEntity>().HasData(
        [
            new CargoEntity { CargoTypeId = cargoTypes[0].Id, Requirements = "Не ставить друг на друга"},
            new CargoEntity { CargoTypeId = cargoTypes[2].Id, Requirements = "Не переворачивать"},
            new CargoEntity { CargoTypeId = cargoTypes[3].Id}
        ]);
    }

    private static void CreateTypes(ModelBuilder modelBuilder, CargoTypeEntity[] cargoTypes)
    {
        modelBuilder.Entity<CargoTypeEntity>().HasData(cargoTypes);
    }

    private static void CreateCars(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CarEntity>().HasData(
        [
            new CarEntity { Brand = "BMW", Number = "A123BB", LoadCapacityPerKg = 1000 },
            new CarEntity { Brand = "BMW", Number = "A123BC", LoadCapacityPerKg = 500},
            new CarEntity { Brand = "Mercedes-Benz", Number = "B222BK", LoadCapacityPerKg = 500},
            new CarEntity { Brand = "Lada", Number = "K234OM", LoadCapacityPerKg = 600}
        ]);
    }
}
