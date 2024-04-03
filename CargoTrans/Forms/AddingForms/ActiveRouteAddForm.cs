using Application.Services;
using Core.Models;

namespace View.Forms
{
    public partial class ActiveRouteAddForm : Form
    {
        private readonly CargoService _cargoService;
        private readonly CarService _carService;

        public ActiveRouteAddForm(CargoService cargoService, CarService carService)
        {
            InitializeComponent();
            _cargoService = cargoService;
            _carService = carService;
        }

        private void AppendButton_Click(object sender, EventArgs e)
        {

        }

        private void ActiveRouteAddForm_Load(object sender, EventArgs e)
        {
            LoadAutoCompleteData();
        }

        private async void LoadAutoCompleteData()
        {
            var cargosDict = new Dictionary<string, Cargo>();

            var cargos = await _cargoService.GetCargosAsync();

            cargoComboBox.Items.Clear();

            //Тут лучше изменить свойство у груза, для более удачного отображения            
            foreach (var cargo in cargos)
            {
                var name = cargo.Type.Name;
                cargosDict.Add(name, cargo);
                cargoComboBox.Items.Add(name);
            }


            var carDict = new Dictionary<string, Car>();

            var cars = await _carService.GetCarsAsync();

            carComboBox.Items.Clear();

            foreach (var car in cars)
            {
                carDict.Add(car.Number, car);
            }

            carComboBox.DataSource = new BindingSource(carDict, null);
        }
    }
}
