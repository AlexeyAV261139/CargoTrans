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
        private readonly CargoTypeService _cargoTypeService;

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
            _routeService = new RouteService(new RouteRepository(_dbContext));
            _cargoTypeService = new CargoTypeService(new CargoTypesRepository(_dbContext));

            Add = () => new CarAddForm().Show();
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
            Add = () => new CarAddForm().Show();


            var cars = await _carService.GetCars();

            dataGridViewMain.DataSource = cars.ToDataTable();
            dataGridViewMain.Columns["Id"].Visible = false;
        }

        private async Task DisplayDriversAsync()
        {
            Add = () => new DriverAddForm(_driverService).Show();

            var drivers = await _driverService.GetDriversAsync();

            dataGridViewMain.DataSource = drivers.ToDataTable();
            dataGridViewMain.Columns["Id"].Visible = false;
        }

        private async Task DisplayRoutesAsync()
        {
            Add = () => new RouteAddForm().Show();

            var routes = await _routeService.GetRoutesAsync();

            dataGridViewMain.DataSource = routes.ToDataTable();
            dataGridViewMain.Columns["Id"].Visible = false;
        }

        private async Task DisplayActiveRoutesAsync()
        {
            Add = () => new ActiveRouteAddForm().Show();

            var activeRoutes = await _activeRouteService.GetActiveRoutesAsync();
            dataGridViewMain.DataSource = activeRoutes;
            dataGridViewMain.Columns["Id"].Visible = false;
        }

        private async Task DisplayCargosAsync()
        {
            Add = () => new CargoAddForm(_cargoService, _cargoTypeService).Show();
            var cargos = await _cargoService.GetCargosAsync();

            dataGridViewMain.DataSource = cargos.ToDataTable();
            dataGridViewMain.Columns["Id"].Visible = false;
        }

        private void AddButton_Click(object sender, EventArgs e) => Add();            
    }
}
