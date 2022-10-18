// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int Function(int m, int n)
{
if (m == 0) 
return n + 1;

else if (n == 0) 
return Function(m - 1, 1);

else return Function(m - 1, Function(m, n - 1));
}

int GetNumbers(string numbers) 
{
  Console.Write(numbers);
  int  result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int m = GetNumbers("Введите m: ");
int n = GetNumbers("Введите n: ");

int functionAkkerman = Function(m, n);

Console.WriteLine($"Функция Аккермана чисел {m}, {n} = {functionAkkerman} ");