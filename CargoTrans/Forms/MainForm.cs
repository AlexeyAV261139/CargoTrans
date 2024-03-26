using Application.Interfaces.Services;
using DB;
using DB.Repositories;
using System.ComponentModel;
using View.Forms;

namespace CargoTrans
{
       
    public partial class MainForm : Form
    {
        private readonly CargosDbContext _dbContext;
        private readonly CargoService _cargoService;
        private readonly CarService _carService;
        private readonly FormOpener _formOpener;

        private Action Add;


        public MainForm()
        {
            InitializeComponent();
            _dbContext = new CargosDbContext();
            _cargoService = new CargoService(new CargoRepository(_dbContext));
            _carService = new CarService(new CarRepository(_dbContext));
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

        private void ActiveRoutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayActiveRoutesAsync();
        }

        private void DisplayActiveRoutesAsync()
        {
            throw new NotImplementedException();
        }

        private async void CargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await DisplayCargosAsync();
        }

        private async Task DisplayCargosAsync()
        {
            Add = _formOpener.AddCargo;
            var cargos = await _cargoService.GetCargosAsync();

            dataGridViewMain.DataSource = cargos.ToDataTable();
            dataGridViewMain.Columns["Id"].Visible = false;
        }
        
        private async void CarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add = _formOpener.AddCar;
            await DisplayCarsAsync();
        }

        private async Task DisplayCarsAsync()
        {
            var cars = await _carService.GetCars();

            dataGridViewMain.DataSource = cars.ToDataTable();
            dataGridViewMain.Columns["Id"].Visible = false;
        }

        private void DriversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayDriversAsync();
        }

        private void DisplayDriversAsync()
        {
            throw new NotImplementedException();
        }

        private void RoutesToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

    }
}
