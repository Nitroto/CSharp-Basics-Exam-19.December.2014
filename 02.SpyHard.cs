using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

class SpyHard
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int key = int.Parse(Console.ReadLine());
        string message = Console.ReadLine();
        char[] messageArray = message.ToUpper().ToCharArray();
        int messageValue = 0;
        foreach (char character in messageArray)
        {
            if (character >= 'A' && character <= 'Z')
            {
                messageValue += character - 'A' + 1;
            }
            else
            {
                messageValue += (int)character;
            }
        }
        List<int> charsForNewMessage = new List<int>();
        while (messageValue>1)
        {
            int newMessage = messageValue % key;
            messageValue /=  key;
            charsForNewMessage.Add(newMessage);
        }
        if (messageValue > 0)
        {
            charsForNewMessage.Add(messageValue);
        }
        string printMessage = "" + key + messageArray.Length;
        for (int i = (charsForNewMessage.Count-1); i >= 0; i--)
        {
            printMessage += charsForNewMessage[i];
        }
        Console.WriteLine(printMessage);
    }
}
