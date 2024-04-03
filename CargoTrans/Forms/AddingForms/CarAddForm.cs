using Application.Services;
using Core.Models;

namespace View.Forms
{
    public partial class CarAddForm : Form
    {
        private readonly CarService _service;

        public CarAddForm(CarService service)
        {
            InitializeComponent();
            _service = service;
        }

        private async void appendButton_Click(object sender, EventArgs e)
        {
            try
            {
                var car = GetCarFromForm();
                await _service.CreateCar(car);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Успешно!");
            }
        }

        private Car GetCarFromForm()
        {
            if (!int.TryParse(capacityTextBox.Text, out var capacity) || capacity < 0)
                throw new Exception("некорректная вместимость");

            return new Car
            {
                Brand = brandTextBox.Text,
                Number = numberMaskedTextBox.Text,
                LoadCapacityPerKg = capacity
            };
        }
    }
}
