using DB;
using DB.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace CargoTrans
{
    public partial class MainForm : Form
    {
        private CargosDbContext? _dbContext;

        public MainForm()
        {
            InitializeComponent();
        }


        protected override void OnLoad(EventArgs e)
        {
            _dbContext = new CargosDbContext();

            _dbContext.ActiveRoutes.Load();
            dataGridViewMain.DataSource = _dbContext.ActiveRoutes.Local.ToBindingList();
        }


        protected override void OnClosing(CancelEventArgs e)
        {
            _dbContext?.Dispose();
            _dbContext = null;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _dbContext?.SaveChanges();
        }

        private void ActiveRoutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dbContext.ActiveRoutes.Load();
            dataGridViewMain.DataSource = _dbContext.ActiveRoutes.Local.ToBindingList();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dbContext.Cargos.Load();
            dataGridViewMain.DataSource = _dbContext.Cargos.Local.ToBindingList();
        }

        private void CarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dbContext.Cars.Load();
            dataGridViewMain.DataSource = _dbContext.Cars.Local.ToBindingList();
        }

        private void DriversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dbContext.Drivers.Load();
            dataGridViewMain.DataSource = _dbContext.Drivers.Local.ToBindingList();
        }

        private void RoutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dbContext.Routes.Load();
            dataGridViewMain.DataSource = _dbContext.Routes.Local.ToBindingList();
        }
    }
}
