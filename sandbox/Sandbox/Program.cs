using System;
using System.Diagnostics.Tracing;

class Circle
{
    private double _radius;
    public void SetRadius(double radius)
    {
        if(radius < 0)
        {
            Console.WriteLine("error");
            return;
        }
        _radius = radius;
    }
    double GetRadius()
    {
        return _radius;
    }
}
class Program
{
    static void Main(string[] args)
{
//     //     //04-29-25
//     //     int x = 300;
//     //     if (x ==10)
//     //     {
//     //         Console.WriteLine("X is 10");
//     //     }
//     //     for(int i = 0; i<x; i++)
//     //     {Console.WriteLine($"Bob is cool: {i}");}
    
// // in class 05/1/25
//     // int x = 0;
//     // int y = x++;
//     // Console.WriteLine(y);
//     // Console.WriteLine(x);
//     // List<int> myNumbers = new List<int>();
//     // myNumbers.Add(10);
//     // myNumbers.Add(99);
//     // myNumbers.Add(69);
//     // foreach(int i in myNumbers)
//     // {
//     //     Console.WriteLine(i);
//     // }
//     // double total = AddNumbers();
    
    Circle myCircle = new Circle();
    myCircle.SetRadius(10);
    Console.WriteLine($"{myCircle}");
    }

}
//in class for
// randon generator = new Random();
//in randomNumber = new randomGenerator(1,100)