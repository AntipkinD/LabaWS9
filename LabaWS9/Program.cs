using LabaWS9;

internal class Program
{
    delegate void CWCleaner(Car car);

    private static void Main(string[] args)
    {
        Car audi = new Car("AUDI TT", "КП345Т");
        Washer CleanWheel = new();
        Garage myGarage = new();
        audi.getInfo();
        myGarage.Stay(audi);
        Car[] cars = new Car[5];
        cars[0] = audi;
        for (int i = cars.Length-1; i >= 1; i--)
        {
            cars[i] = new Car();
        }
        //CleanWheel.Wash(audi);
        CWCleaner cleaner = CleanWheel.Wash;
        for (int i = cars.Length-1; i >= 0; i--)
        {
            cleaner(cars[i]);
        }
    }
}