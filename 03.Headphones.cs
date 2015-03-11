using System;
using System.Globalization;
using System.Threading;

class Headphones
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int diameter = int.Parse(Console.ReadLine());

        Console.Write(new string('-', diameter / 2));
        Console.Write(new string('*', diameter + 2));
        Console.Write(new string('-', diameter / 2));
        Console.WriteLine();
        for (int i = 0; i < diameter - 1; i++)
        {
            Console.Write(new string('-', diameter / 2));
            Console.Write('*');
            Console.Write(new string('-', diameter));
            Console.Write('*');
            Console.Write(new string('-', diameter / 2));
            Console.WriteLine();
        }
        int spacesBefore = diameter / 2;
        int spacesMiddle = diameter;
        int body = 1;
        for (int i = 0; i < diameter; i++)
        {
            
            Console.Write(new string('-', spacesBefore));
            Console.Write(new string('*', body));
            Console.Write(new string('-', spacesMiddle));
            Console.Write(new string('*', body));
            Console.Write(new string('-', spacesBefore));
            if (i < diameter / 2)
            {
                body += 2;
                spacesBefore--;
                spacesMiddle -= 2;
            }
            else
            {
                body -= 2;
                spacesBefore++;
                spacesMiddle += 2;
            }
            Console.WriteLine();
        }

    }
}
