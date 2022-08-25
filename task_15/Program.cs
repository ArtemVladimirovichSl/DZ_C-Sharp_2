Console.Write("Введите число, соответствующее дню недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num>0 && num<6)
{
    Console.WriteLine("Указанный день является рабочим");
}
else if(num>5 && num<8)
{
    Console.WriteLine("Указанный день является выходным");
} 