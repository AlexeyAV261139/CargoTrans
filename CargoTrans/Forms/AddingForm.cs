using Application.Interfaces.Services;
using Core.Models;
using DB;
using DB.Repositories;

namespace View.Forms
{
    public partial class AddingForm : Form
    {
        private readonly CargoService _service;

        public AddingForm()
        {
            InitializeComponent();
            _service = new CargoService(new CargoRepository(new CargosDbContext()));
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            Cargo cargo = GetCargoFromForm();
            await _service.CreateCargo(cargo);
            MessageBox.Show("Успешно");
        }

        private Cargo GetCargoFromForm()
        {
            return new Cargo
            {
                Type = TypeTextBox.Text,
                Requirements = textBox1.Text
            };
        }
    }
}
