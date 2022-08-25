Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int num1 = (int)Math.Log10(num)-2;
Console.WriteLine(num1 < 0 ? "В заданном числе третьей цифры нет" : (num % (int)Math.Pow(10, num1 + 1) / (int)Math.Pow(10, num1)).ToString());