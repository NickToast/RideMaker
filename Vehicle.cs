public class Vehicle
{
    public string Name {get; set;}
    public int Passengers {get; set;}
    public string Color {get; set;}
    public bool HasEngine {get; set;}
    private int Mileage = 0;

    public Vehicle (string name, int passengers, string color, bool hasEngine)
    {
        Name = name;
        Passengers = passengers;
        Color = color;
        HasEngine = hasEngine;
    }

    public Vehicle (string name, string color)
    {
        Name = name;
        Passengers = 4;
        Color = color;
        HasEngine = true;
        Mileage = 100;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Name of Vehicle: {Name}");
        Console.WriteLine($"Number of Passengers: {Passengers}");
        Console.WriteLine($"Color: {Color}");
        Console.WriteLine($"Has Engine: {HasEngine}");
        Console.WriteLine($"Mileage: {Mileage}");
    }

    public void Travel(int miles)
    {
        Mileage += miles;
        Console.WriteLine($"{Name} has traveled {miles} miles. Total distance traveled is {Mileage} miles.");
    }

}