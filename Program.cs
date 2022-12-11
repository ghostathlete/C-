//задача2 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите 1 число ");
string inputValue1 = Console.ReadLine();
int value1 = Convert.ToInt32(inputValue1);

Console.Write("Введите 2 число ");
string inputValue2 = Console.ReadLine();
int value2 = Convert.ToInt32(inputValue2);

Console.Write("Введите 3 число ");
string inputValue3 = Console.ReadLine();
int value3 = Convert.ToInt32(inputValue3);

if (value1 > value2&&value1 > value3)
{
    System.Console.WriteLine ($"Из введенных чисел {value1} , {value2}, {value3} большим является {value1}");
}
else if (value2 > value1&&value2 > value3)
{
    System.Console.WriteLine ($"Из введенных чисел {value1} , {value2}, {value3} большим является {value2}");
}
else if (value3 > value1&&value3 > value2)
{
    System.Console.WriteLine ($"Из введенных чисел {value1} , {value2}, {value3} большим является {value3}");
}

else if (value1 == value2&&value2 == value3) 
{
    System.Console.WriteLine ($"Числа {value1} , {value2}, {value3} между собой равны");
}