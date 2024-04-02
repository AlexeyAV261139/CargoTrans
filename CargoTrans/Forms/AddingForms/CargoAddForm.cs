using Application.Interfaces.Services;
using Core.Models;

namespace View.Forms
{
    public partial class CargoAddForm : Form
    {
        private readonly CargoService _cargoService;
        private readonly CargoTypeService _typeService;
        private List<CargoType> _loadedTypes = [];

        private string TypeText => TypeTextBox.Text.Trim();

        private string ReequipmentsText => reequipmentsTextBox1.Text.Trim();

        public CargoAddForm(CargoService cargoService, CargoTypeService typeService)
        {
            InitializeComponent();
            _typeService = typeService;
            _cargoService = cargoService;
        }

        private async void CargoAddForm_Load(object sender, EventArgs e)
            => await FillTextBoxAutoCompleteData();

        private async Task FillTextBoxAutoCompleteData()
        {
            await LoadTypes();

            var typesNames = _loadedTypes
                            .Select(t => t.ToString())
                            .ToArray();

            AutoCompleteStringCollection source = [];
            source.AddRange(typesNames);

            TypeTextBox.AutoCompleteCustomSource = source;
            TypeTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TypeTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private async Task LoadTypes() => 
            _loadedTypes = await _typeService.GetCargoTypesAsync();


        private async void AddButton_Click(object sender, EventArgs e)
        {
            Cargo cargo = await GetCargoFromFormAsync();
            await _cargoService.CreateCargoAsync(cargo);
            MessageBox.Show("Успешно");
        }
        

        private async Task<Cargo> GetCargoFromFormAsync()
        {
            var type = _loadedTypes.FirstOrDefault(t => t.Name == TypeTextBox.Text);
            if (type is null)
            {
                type = new CargoType
                {
                    Name = TypeText,
                };
                await _typeService.CreateTypeAsync(type);                
            }
            return new Cargo
            {                
                Reequipments = ReequipmentsText,
                Type = type,
            };
        }  
    }
}
