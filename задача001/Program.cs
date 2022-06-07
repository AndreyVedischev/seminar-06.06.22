Console.Clear();
Console.Write("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if((a*a) == b) Console.WriteLine("Число b является квадратом числа а.");
else           Console.WriteLine("Число b не является квадратом числа а.");
