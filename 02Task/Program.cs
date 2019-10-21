//Превърнете числото 1111010110011110(2) в шестнадесетична и в десе-
//тична бройна система.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("1111010110011110 to Hex is: {0} ", Convert.ToInt64("1111010110011110", 2).ToString("X"));
        Console.WriteLine("1111010110011110 to Decimal is {0}.", Convert.ToInt32("1111010110011110", 2));

    }
}
