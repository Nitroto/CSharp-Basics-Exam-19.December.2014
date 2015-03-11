using System;
using System.Globalization;
using System.Threading;

class SpiralMatrix
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        string userInput = Console.ReadLine().ToLower();
        char[] keyWord = userInput.ToCharArray();
        char[,] spiralMatrix = new char[n, n];
        int row = 0;
        int col = 0;
        int index = 0;
        string direction = "right";
        for (int i = 0; i < spiralMatrix.Length; i++)
        {
            if (direction == "right" && (col == spiralMatrix.GetLength(1) || spiralMatrix[row, col] != '\0'))
            {
                direction = "down";
                col--;
                row++;
            }
            else if (direction == "down" && (row == spiralMatrix.GetLength(0) || spiralMatrix[row, col] != '\0'))
            {
                direction = "left";
                col--;
                row--;
            }
            else if (direction == "left" && (col < 0 || spiralMatrix[row, col] != '\0'))
            {
                direction = "up";
                col++;
                row--;
            }
            else if (direction == "up" && (row < 0 || spiralMatrix[row, col] != '\0'))
            {
                direction = "right";
                col++;
                row++;
            }

            spiralMatrix[row, col] = keyWord[index];
            index = GetNextChar(keyWord, index);
            if (direction == "right")
            {
                col++;
            }
            else if (direction == "down")
            {
                row++;
            }
            else if (direction == "left")
            {
                col--;
            }
            else if (direction == "up")
            {
                row--;
            }
        }
        int biggestRow = int.MinValue;
        int rowIndex = 0;
        for (int i = 0; i < spiralMatrix.GetLength(0); i++)
        {
            int currentRow = 0;
            for (int j = 0; j < spiralMatrix.GetLength(1); j++)
            {
                currentRow += ((spiralMatrix[i, j] - 'a' + 1) * 10);
            }
            if (currentRow > biggestRow)
            {
                biggestRow = currentRow;
                rowIndex = i;
            }
        }
        Console.WriteLine("{0} - {1}", rowIndex, biggestRow);
    }

    private static int GetNextChar(char[] keyWord, int index)
    {
        if (index < keyWord.Length - 1)
        {
            index++;
        }
        else if (index != 0)
        {
            index = 0;
        }

        return index;
    }
}

