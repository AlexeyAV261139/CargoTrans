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


        public MainForm()
        {
            InitializeComponent();
            _dbContext = new CargosDbContext();
            _cargoService = new CargoService(new CargoRepository(_dbContext));
        }

        protected async override void OnLoad(EventArgs e)
        {
            await DisplayCargosAsync();
        }

        private async Task DisplayCargosAsync()
        {
            var cargos = await _cargoService.GetCargosAsync();

            dataGridViewMain.DataSource = cargos.ToDataTable();
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

        private async void CarsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DriversToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RoutesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddingForm();
            addForm.Show();
        }
    }
}
