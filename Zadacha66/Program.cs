// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

void GetSum(int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Console.WriteLine($"Сумма элементов = {sum} ");
    return;
  }
  GetSum(m, n - 1, sum);
}

int GetNumbers(string numbers) 
{
  Console.Write(numbers);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int m = GetNumbers("Введите m: ");
int n = GetNumbers("Введите n: ");
int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

GetSum(m, n, temp=0);