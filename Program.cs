//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число ");
string inputValue1 = Console.ReadLine();
int value1 = Convert.ToInt32(inputValue1);
int even = 0;
while (even < value1)
{
    even++;
    if (even % 2 == 0)
    {
        System.Console.WriteLine(even);
    }
}