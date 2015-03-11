using System;
using System.Globalization;
using System.Threading;
class TravellerBob
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string year = Console.ReadLine();
        int c = int.Parse(Console.ReadLine());
        int f = int.Parse(Console.ReadLine());
        double leap = 0;
        switch (year)
        {
            case "leap": leap = 1.05;break;
            case "normal": leap = 1; break;
        }
        double contractMonth = c * 4 * 3;
        double familyMonth = f * 2 * 2;
        double normalMonth = (12 - c - f) * 4 * 3 * 0.6;
        double totalTravels = (contractMonth+familyMonth + normalMonth) * leap;
        Console.WriteLine((int)totalTravels);
    }
}
