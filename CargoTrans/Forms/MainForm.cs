using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using DB;
using DB.Repositories;
using System.ComponentModel;
using View.Forms;

namespace CargoTrans
{

    public partial class MainForm : Form
    {
        private readonly DriverService _driverService;
        private readonly CargosDbContext _dbContext;
        private readonly CargoService _cargoService;
        private readonly CarService _carService;
        private readonly ActiveRouteService _activeRouteService;
        private readonly RouteService _routeService;
        private readonly FormOpener _formOpener;

        private Action Add;


        public MainForm()
        {
            InitializeComponent();
            _dbContext = new CargosDbContext();

            _cargoService = new CargoService(new CargoRepository(_dbContext));
            _carService = new CarService(new CarRepository(_dbContext));
            _cargoService = new CargoService(new CargoRepository(_dbContext));
            _activeRouteService = new ActiveRouteService(new ActiveRouteRepository(_dbContext));
            _driverService = new DriverService(new DriverRepository(_dbContext));

            _formOpener = new FormOpener();
            Add = _formOpener.AddCargo;
        }

        protected async override void OnLoad(EventArgs e)
        {
            await DisplayCargosAsync();            
        }        

        protected override void OnClosing(CancelEventArgs e)
        {

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
        }

        private async void ActiveRoutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await DisplayActiveRoutesAsync();
        }

        private async void CargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await DisplayCargosAsync();
        }

        private async void CarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await DisplayCarsAsync();
        }

        private async void DriversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await DisplayDriversAsync();
        }


        private async void RoutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await DisplayRoutesAsync();
        }
        private async Task DisplayCarsAsync()
        {
            Add = _formOpener.AddCar;


            var cars = await _carService.GetCars();

            dataGridViewMain.DataSource = cars.ToDataTable();
            dataGridViewMain.Columns["Id"].Visible = false;
        }

        private async Task DisplayDriversAsync()
        {
            Add = _formOpener.AddDriver;

            var drivers = await _driverService.GetDriversAsync();

            dataGridViewMain.DataSource = drivers.ToDataTable();
            dataGridViewMain.Columns["Id"].Visible = false;
        }

        private async Task DisplayRoutesAsync()
        {
            Add = _formOpener.AddRoute;

            var routes = await _routeService.GetRoutesAsync();

            dataGridViewMain.DataSource = routes.ToDataTable();
            dataGridViewMain.Columns["Id"].Visible = false;
        }

        private async Task DisplayActiveRoutesAsync()
        {
            Add = _formOpener.AddActiveRoute;

            var activeRoutes = await _activeRouteService.GetActiveRoutesAsync();
            dataGridViewMain.DataSource = activeRoutes;
            dataGridViewMain.Columns["Id"].Visible = false;
        }

        private async Task DisplayCargosAsync()
        {
            Add = _formOpener.AddCargo;
            var cargos = await _cargoService.GetCargosAsync();

            dataGridViewMain.DataSource = cargos.ToDataTable();
            dataGridViewMain.Columns["Id"].Visible = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Add();            
        }        
    }

    public class FormOpener
    {
        public void AddCargo() => new CargoAddForm().Show();

        public void AddCar() => new CarAddForm().Show();

        public void AddRoute() => new RouteAddForm().Show();

        public void AddDriver() => new DriverAddForm().Show();

        public void AddActiveRoute() => new ActiveRouteAddForm().Show();

    }
}
