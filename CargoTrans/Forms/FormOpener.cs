using View.Forms;

namespace CargoTrans
{
    public class FormOpener
    {
        public void AddCargo() => new CargoAddForm().Show();

        public void AddCar() => new CarAddForm().Show();

        public void AddRoute() => new RouteAddForm().Show();

        public void AddDriver() => new DriverAddForm().Show();

        public void AddActiveRoute() => new ActiveRouteAddForm().Show();

    }
}
