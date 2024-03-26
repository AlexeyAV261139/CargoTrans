using Application.Interfaces.Services;
using Core.Models;
using DB;
using DB.Repositories;

namespace View.Forms
{
    public partial class CargoAddForm : Form
    {
        private readonly CargoService _cargoService;
        private readonly CargoTypeService _typeService;

        public CargoAddForm()
        {
            InitializeComponent();
            var context = new CargosDbContext();
            _cargoService = new CargoService(new CargoRepository(context));
            _typeService = new CargoTypeService(new CargoTypesRepository(context));

           
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            Cargo cargo = GetCargoFromForm();
            await _cargoService.CreateCargoAsync(cargo);
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

        private async void CargoAddForm_Load(object sender, EventArgs e)
        {
            await LoadAutoCompleteDataForTextBox();
        }

        private async Task LoadAutoCompleteDataForTextBox()
        {
            var types = await _typeService.GetCargoTypesAsync();
            var typesNames = types
                .Select(t => t.ToString())
                .ToArray();
            AutoCompleteStringCollection source = [.. typesNames];
            TypeTextBox.AutoCompleteCustomSource = source;
            TypeTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TypeTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }
}
