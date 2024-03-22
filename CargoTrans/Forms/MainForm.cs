using Core.Models;
using DB;
using DB.Repositories;
using System.ComponentModel;

namespace CargoTrans
{

    public partial class MainForm : Form
    {
        private readonly CargosDbContext _dbContext;
        private CargosRepository repos;


        public MainForm()
        {
            InitializeComponent();
            _dbContext = new CargosDbContext();
        }

        protected async override void OnLoad(EventArgs e)
        {
            await DisplayCargosAsync();
        }

        private async Task DisplayCargosAsync()
        {
            repos = new CargosRepository(_dbContext);
            var cargosEntities = await repos.GetWithType();

            var cargos = cargosEntities
                .Select(c => new Cargo
                {
                    Type = c.CargoType.Name,
                    Requirements = c.Requirements
                });

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

    }
}
