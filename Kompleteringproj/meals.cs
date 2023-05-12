using System;

public class Meals
{
    public string Name { get; set; }
    public int fullness { get; set; }
    public bool rotten = true;

    public void rotcheck()
    {
        if (rotten == true)
        {
            Console.WriteLine("Ew, that food was rotten");
        }
    }
}