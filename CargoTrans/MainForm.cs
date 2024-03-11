using DB;
using DB.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
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


        protected async override void OnLoad(EventArgs e)
        {
            _dbContext = new CargosDbContext();

            var cargos = _dbContext.Cargos
                .Include(c => c.CargoType)
                .ToList();
        }


        protected override void OnClosing(CancelEventArgs e)
        {
            _dbContext?.Dispose();
            _dbContext = null;
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            await _dbContext?.SaveChangesAsync();
        }

        private async void ActiveRoutesToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            labelTable.Text = ðåéñûToolStripMenuItem.Text;
            await LoadDataToDataGrid(_dbContext.ActiveRoutes);
        }

        private async void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTable.Text = ãðóçûToolStripMenuItem.Text;
            await LoadDataToDataGrid(_dbContext.Cargos);
        }

        private async void CarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTable.Text = àâòîToolStripMenuItem.Text;
            await LoadDataToDataGrid(_dbContext.Cars);
        }

        private async void DriversToolStripMenuItem_Click(object sender, EventArgs e)
        {

            labelTable.Text = âîäèòåëèToolStripMenuItem.Text;
            await LoadDataToDataGrid(_dbContext.Drivers);
        }

        private  async void RoutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTable.Text = ìàðøðóòûToolStripMenuItem.Text;
            await LoadDataToDataGrid(_dbContext.Routes);
        }

        private async Task LoadDataToDataGrid<T>(DbSet<T> dbSet) where  T : class
        {
            if (dbSet is null) throw new Exception();
            await dbSet.LoadAsync();            
            dataGridViewMain.DataSource = dbSet.Local.ToBindingList();
        }
    }
}
