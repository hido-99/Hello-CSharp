using AbstractFactoryPattern.Contracts;

namespace AbstractFactoryPattern.Implementations
{
    class VehicleFactory
    {
        private IVehicle _vehicle { get; set; }
        private string _vehicleType { get; set; }

        public VehicleFactory(IVehicle vehical)
        {
            _vehicle = vehical;
        }

        public Bike GetBike()
        {
            return _vehicle.GetBike();
        }

        public Car GetCar()
        {
            return _vehicle.GetCar();
        }
    }
}
