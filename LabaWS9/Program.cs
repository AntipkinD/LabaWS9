using LabaWS9;

internal class Program
{
    delegate void CWCleaner(Car car);

    private static void Main(string[] args)
    {
        Car audi = new Car("AUDI TT", "КП345Т");
        Washer CleanWheel = new();
        Garage myGarage = new();
        myGarage.setCars(audi);
        for (int i = 5; i >= 1; i--)
        {
            myGarage.setCars(new Car());
        }
        myGarage.getMyCars();
        //CleanWheel.Wash(audi);
        CWCleaner cleaner = CleanWheel.Wash;
        foreach (Car i in myGarage.garageCollection)
        {
            cleaner(i);
        }
        myGarage.getMyCars();
    }
}