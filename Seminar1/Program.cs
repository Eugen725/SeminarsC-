//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
int num1, num2;

//Ввод данных
Console.Write("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());

//Вычисление max и min
if (num1 > num2)
{
    Console.WriteLine("{0} > {1}", num1, num2);
}
else if (num1 < num2)
{
   Console.WriteLine("{0} < {1}", num1, num2);
}
else
{
   Console.WriteLine("{0} = {1}", num1, num2);
}

// Вывод ответа на экран


//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

int num1, num2, num3;

//Ввод данных
Console.Write("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
num3 = Convert.ToInt32(Console.ReadLine());

//Вычисление max
if (num1 > num2)
    if (num1 > num3)
    {
    Console.WriteLine("{0}, {1}, {2} : max {0}", num1, num2, num3);
    }
    else 
    {
    Console.WriteLine("{0}, {1}, {2} : max {2}", num1, num2, num3);
    }
else if (num2 > num3)
{
   Console.WriteLine("{0}, {1}, {2} : max {1}", num1, num2, num3);
}
else
{
   Console.WriteLine("{0}, {1}, {2} : max {2}", num1, num2, num3);
}

// Вывод ответа на экран


//Напишите программу, которая на вход принимает число и выдаёт,
//является ли число чётным (делится ли оно на два без остатка).

int num;

//Ввод данных
Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

//Вычисление
if (num % 2 == 0)
    {
    Console.WriteLine("Четное число");
    }
else 
    {
    Console.WriteLine("Нечетное число");
    }

// Вывод ответа на экран


//Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.

int num;

//Ввод данных
Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

int current = 1;

//Вычисление
while (current<=num){
     if (current % 2 == 0)
     Console.Write(current + " ");
     current++;
}

// Вывод ответа на экран


*/