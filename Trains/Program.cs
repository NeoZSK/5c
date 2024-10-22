
Vehicle v = new Vehicle(17, "Yellow", new DateOnly(2001, 09, 11));

Console.WriteLine(v.ToString());
v.Run();

class Vehicle
{

    private int numberOfWheels;
    private string color;
    private DateOnly productionDate;

    public Vehicle(int numberOfWheels, string color, DateOnly productionDate)
    {
        if(numberOfWheels < 1)
        {
            throw new Exception("Vehicle should have at least 1 wheel");
        } 

        this.numberOfWheels = numberOfWheels;
        this.color = color;
        this.productionDate = productionDate;
    }

    public override string ToString()
    {
        return $"This is Vehicle.\n It has {numberOfWheels} wheels, {color} color and it was produced at {productionDate.ToString()}";
    }

    public void Run()
    {
        Console.WriteLine("It is running");
    }

}