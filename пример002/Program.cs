Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int CurentN = number*-1;
while(CurentN<=number)
{
    Console.Write(CurentN);
    Console.Write(", ");
    CurentN++;
}