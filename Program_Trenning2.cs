List<int> nums = new List<int>();
nums.Add(777);
nums.Add(666);
nums.Add(13);

nums.Remove(777);

for (int i = 0; i < nums.Count; i++)
{
    Console.WriteLine(nums[i]);
}


Console.WriteLine("HA HA HA HA HA HA HA HA HA HA");

int[,] arr = new int[3, 2]
{
    {2,8}, {23, 5}, {87,21}
};

Console.WriteLine(arr[0, 0]);

Console.WriteLine(arr[1, 0]);

Console.WriteLine(arr[2, 0]);

foreach (double ei in arr)
{
    Console.WriteLine(ei);
}

for (long i = 1011001110110110010; i > 10; i++)
{
    Console.Write(i);
}

Console.WriteLine();

while (true)
{
    Console.Write("101010001111000101010011");
}


double[] nums = { 1.23, 32.21, 66.13 };
foreach (double i in nums)
{
    Console.WriteLine(i);
}

public static void Main(string[] args)
{
    Print("Hi")

}
public static void Print(string[] str)
{
    Console.WriteLine(str);
}

using System.Security.AccessControl;

public class Cars
{
    public string name = "Renault";
    public int wheels = 4;
    public double speed = 180.00;
    public bool isWorking = true;

    public void setValues(double speed, bool isWorking)
    {
        this.speed = speed;
        this.isWorking = isWorking;
    }
    public void vuvodaboutsharact()
    {
        Console.WriteLine($"Speed:{this.speed},CArs Working?:{isWorking}");
    }

}

class GlavClass
{
    public static void Main(string[] args)
    {
        Cars Lamborgini = new Cars();
        Console.WriteLine(Lamborgini.wheels);
        Lamborgini.setValues(230.5, true);
        Lamborgini.vuvodaboutsharact();

        Cars Shevrolete = new Cars();
        Shevrolete.name = "Pokemon";
        Shevrolete.wheels = 89239;
        Console.WriteLine(Shevrolete.speed);
        Shevrolete.vuvodaboutsharact();




    }
}


