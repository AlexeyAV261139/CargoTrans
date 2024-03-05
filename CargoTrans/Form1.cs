using DB;
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
            base.OnLoad(e);

            _dbContext = new CargosDbContext();

            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            _dbContext.Database.EnsureCreated();
            _dbContext.CargoTypes.Load();

            bindingSourceCargoTypes.DataSource = _dbContext.CargoTypes.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }

    }
}
