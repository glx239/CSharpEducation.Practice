namespace Task10;

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        car.model = "Mercedes";
    }

    static void PrintCar(Car car)
    {
        Console.WriteLine(car.model);
    }
}