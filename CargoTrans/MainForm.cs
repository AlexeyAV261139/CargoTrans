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
            LoadDataToDataGridView();

            void LoadDataToDataGridView()
            {
                _dbContext = new CargosDbContext();
                _dbContext.ActiveRoutes.Load();
                dataGridViewCargoType.DataSource = _dbContext.ActiveRoutes.Local.ToBindingList();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            _dbContext?.Dispose();
            _dbContext = null;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }        

        private void ActiveRoutesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
