using Application.Services;
using Core.Models;

namespace View.Forms
{
    public partial class RouteAddForm : Form
    {
        private readonly RouteService _routeService;

        public RouteAddForm(RouteService routeService)
        {
            InitializeComponent();
            _routeService = routeService;
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            var route = GetRouteFromForm();

            await _routeService.CreateRouteAsync(route);

            MessageBox.Show("Успешно!");
        }

        private Route GetRouteFromForm()
        {
            if (!int.TryParse(distanceTextBox.Text, out int distance) || distance < 0)
                throw new Exception("Некорректное значение расстояния");
            if (!int.TryParse(priceTextBox.Text, out int price) || price < 0)
                throw new Exception("Некорректное значение цены");

            return new Route
            {
                Destination = destinationTextBox.Text,
                Distance = distance,
                Price = price,
            };
        }
    }
}
