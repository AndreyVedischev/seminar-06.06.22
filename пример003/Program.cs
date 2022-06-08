Console.Clear();
Console.Write("Введите трехзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());

if((Math.Abs(N) < 100) ||(Math.Abs(N)>999)){
    Console.WriteLine("Введено не трехзначное число!!!");
    return;
}

Console.WriteLine(N%10);