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


        public MainForm()
        {
            InitializeComponent();
            _dbContext = new CargosDbContext();
            _cargoService = new CargoService(new CargoRepository(_dbContext));
            _carService = new CarService(new CarRepository(_dbContext));
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
            dataGridViewMain.DataSource = null;
        }

        private void ActiveRoutesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async void CargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await DisplayCargosAsync();
        }

        private async Task DisplayCargosAsync()
        {
            var cargos = await _cargoService.GetCargosAsync();

            dataGridViewMain.DataSource = cargos.ToDataTable();
            dataGridViewMain.Columns["Id"].Visible = false;
        }

        private async void CarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        }

        private void RoutesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addForm = new CargoAddForm();
            addForm.Show();
        }
    }
}
