using Application.Interfaces.Services;
using DB;
using DB.Repositories;
using View.Forms;

namespace CargoTrans
{
    public partial class MainForm : Form
    {
        private readonly CargosDbContext _dbContext;
        private readonly DriverService _driverService;
        private readonly CargoService _cargoService;
        private readonly CarService _carService;
        private readonly ActiveRouteService _activeRouteService;
        private readonly RouteService _routeService;
        private readonly CargoTypeService _cargoTypeService;

        private Action OpenAppendForm;

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

            OpenAppendForm = new CarAddForm(_carService).Show;
        }

        protected override void OnLoad(EventArgs e) => CargoToolStripMenuItem_Click(this, e);

        private async void ActiveRoutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeFormForAppendButtonOn(new ActiveRouteAddForm());
            var activeRoutes = await _activeRouteService.GetActiveRoutesAsync();
            DisplayListOnDataTable(activeRoutes);
        }

        private async void CargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeFormForAppendButtonOn(new CargoAddForm(_cargoService, _cargoTypeService));
            var cargos = await _cargoService.GetCargosAsync();
            DisplayListOnDataTable(cargos);
        }

        private async void CarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeFormForAppendButtonOn(new CarAddForm(_carService));
            var cars = await _carService.GetCars();
            DisplayListOnDataTable(cars);
        }

        private async void DriversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeFormForAppendButtonOn(new DriverAddForm(_driverService));
            var drivers = await _driverService.GetDriversAsync();
            DisplayListOnDataTable(drivers);
        }

        private async void RoutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeFormForAppendButtonOn(new RouteAddForm(_routeService));
            var routes = await _routeService.GetRoutesAsync();
            DisplayListOnDataTable(routes);
        } 

        private void DisplayListOnDataTable<T>(List<T> data)
        {
            dataGridViewMain.DataSource = data.ToDataTable();
            dataGridViewMain.Columns["Id"].Visible = false;
        }

        private void ChangeFormForAppendButtonOn(Form form)
           => OpenAppendForm = form.Show;

        private void AppendButton_Click(object sender, EventArgs e) => OpenAppendForm();            
    }
}
