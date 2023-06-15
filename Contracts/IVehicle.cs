using AbstractFactoryPattern.Implementations;

namespace AbstractFactoryPattern.Contracts
{
    interface IVehicle
    {
        Bike GetBike();
        Car GetCar();
    }
}
