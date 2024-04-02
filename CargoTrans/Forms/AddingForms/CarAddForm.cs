using Application.Interfaces.Services;
using Core.Models;

namespace View.Forms
{
    public partial class CarAddForm : Form
    {
        private readonly CarService _carService;

        private string Brand => brandTextBox.Text.Trim();

        private string Number => numberMaskedTextBox.Text.Trim();

        private int Capacity =>
            int.TryParse(capacityTextBox.Text, out int capacity) ? capacity : throw new Exception("Некорректная грузоподъемность");


        public CarAddForm(CarService carService)
        {
            InitializeComponent();
            _carService = carService;
        }

        private async void AppendButton_Click(object sender, EventArgs e)
        {
            try
            {
                Car car = GerCarFromForm();
                await _carService.CreateCar(car);
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

        private Car GerCarFromForm()
            => new()
            {
                Brand = Brand,
                Number = Number,
                LoadCapacityPerKg = Capacity
            };
    }
}
