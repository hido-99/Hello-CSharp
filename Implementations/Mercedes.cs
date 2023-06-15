using AbstractFactoryPattern.Contracts;

namespace AbstractFactoryPattern.Implementations
{
    class Mercedes : IVehicle
    {
        public Bike GetBike()
        {
            return new Bike() { BikeName = "You got Mercedes bike!" };
        }

        public Car GetCar()
        {
            return new Car() { CarName = "You got Mercedes car!" };
        }
    }
}
