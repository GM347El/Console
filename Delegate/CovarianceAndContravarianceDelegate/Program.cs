
using CovarianceAndContravarianceDelegate;

CarFactoryDel carFactoryDel = CarFactory.ReturnICECar;
Car iceCar = carFactoryDel(1, "Audi R8");
LogICECarDetailsDel logICECarDetailsDel = CarFactory.LogCarDetails;
logICECarDetailsDel(iceCar as ICECar);
/*System.Console.WriteLine($"object type: {iceCar.GetType()}");
System.Console.WriteLine($"Car Details: {iceCar.GetCarDetails()}");*/

carFactoryDel = CarFactory.ReturnEVCar;
Car evCar = carFactoryDel(2, "Tesla");
LogEVCarDetailsDel logEVCarDetailsDel = CarFactory.LogCarDetails;
logEVCarDetailsDel(evCar as EVCar);
/*System.Console.WriteLine($"object type: {evCar.GetType()}");
System.Console.WriteLine($"Car Details: {evCar.GetCarDetails()}");*/


#region not main
delegate Car CarFactoryDel(int id, string name);
delegate void LogICECarDetailsDel(ICECar car);
delegate void LogEVCarDetailsDel(EVCar car);

public static class CarFactory
{
    public static ICECar ReturnICECar(int _id, string _name) => new ICECar() { id = _id, name = _name };
    public static EVCar ReturnEVCar(int _id, string _name) => new EVCar() { id = _id, name = _name };
    public static void LogCarDetails(Car car)
    {
        if (car is EVCar)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "EVCarLog.txt"), true))
            {
                sw.WriteLine($"{car.GetType()}");
                sw.WriteLine($"{car.GetCarDetails()} - Electric");
            };
        }
        else if (car is ICECar)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ICECarLog.txt"), true))
            {
                sw.WriteLine($"{car.GetType()}");
                sw.WriteLine($"{car.GetCarDetails()} - Internal Combustion Engine");
            };
        }
        else
        {
            throw new ArgumentException("no such a car");
        }
    }
}



public abstract class Car
{
    int Id;
    string? Name;
    public int id { get { return Id; } set { Id = value; } }
    public string name { get { return Name; } set { Name = value; } }
    public virtual string GetCarDetails() => $"{Id} {Name}";
}

public class ICECar : Car
{
    public override string GetCarDetails() => $"{base.GetCarDetails()} - Internal Combustion Engine";
}

public class EVCar : Car
{
    public override string GetCarDetails() => $"{base.GetCarDetails()} - Electric";
}
#endregion not main