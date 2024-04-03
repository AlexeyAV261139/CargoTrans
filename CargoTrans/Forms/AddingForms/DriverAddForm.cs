using Application.Services;
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
            try
            {
                Driver driver = GetDriverFromForm();
                await _driverService.CreateDriverAsync(driver);
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

        private Driver GetDriverFromForm()
        {
            return new Driver
            {
                FirstName = nameTextBox.Text,
                LastName = surnameTextBox.Text,
                Phone = phoneMaskedTextBox.Text
            };
        }
    }
}
