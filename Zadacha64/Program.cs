int GetNumber()
{
    Console.WriteLine("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

void WriteNumbersRecursionVoid(int startNumber, int lastNumber)
{
    if (lastNumber <= startNumber)
    {
        Console.WriteLine(startNumber );
        WriteNumbersRecursionVoid(startNumber-1, lastNumber);
    }     
}

int n = GetNumber();
Console.WriteLine();
WriteNumbersRecursionVoid(n, 1);
