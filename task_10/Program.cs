Console.WriteLine("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 99 && num < 1000)
{
    int num1 = (num/10)%10;
    Console.Write("Вторая цифра введённого числа - " + num1);
}
else
{
    Console.Write("Убедитесь, что число трёхзначное.");
}