using Application.Interfaces.Services;
using Core.Models;

namespace View.Forms
{
    public partial class CargoAddForm : Form
    {
        private readonly CargoService _cargoService;
        private readonly CargoTypeService _typeService;

        public CargoAddForm(CargoService cargoService, CargoTypeService typeService)
        {
            InitializeComponent();
            _typeService = typeService;
            _cargoService = cargoService;
        }

        private async void CargoAddForm_Load(object sender, EventArgs e)
        {
            await LoadAutoCompleteDataForTextBox();
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cargo cargo = GetCargoFromForm();
                await _cargoService.CreateCargoAsync(cargo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Успешно");
            }
        }


        private Cargo GetCargoFromForm()
        {
            return new Cargo
            {
                Type = TypeTextBox.Text,
                Requirements = textBox1.Text
            };
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
