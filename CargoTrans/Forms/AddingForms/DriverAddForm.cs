using Application.Interfaces.Services;
using Core.Models;

namespace View.Forms
{
    public partial class DriverAddForm : Form
    {
        private readonly DriverService _driverService;

        public DriverAddForm(DriverService driverService)
        {
            InitializeComponent();
            _driverService = driverService;
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            Driver driver = GetDriverFromForm();
            await _driverService.CreateDriverAsync(driver);
            MessageBox.Show("Успешно");
            this.Close();
        }

        private Driver GetDriverFromForm()
        {
            return new Driver
            {
                FirstName = nameTextBox.Text,
                LastName = surnameTextBox.Text,
                Phone = phopeTextBox.Text
            };
        }
    }
}
