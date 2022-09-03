// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
//ввод функции 
int Exp(int A, int B){
    int result = 1;
    for (int i = 1; i <= B; i++){
        result *= A;
    }
    return result;
}

//ввод данных
Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

//вычисление через функцию
int exponentiation = Exp(A, B);
Console.WriteLine($"Число {A} в {B} степени равно " + exponentiation);

// вывод ответа на экран


//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

  int Sum(int num){
    
    int count = Convert.ToString(num).Length;
    int cur = 0;
    int result = 0;

    for (int i = 0; i < count; i++){
      cur = num - num % 10;
      result = result + (num - cur);
      num = num / 10;
    }
   return result;
  }

int sumNumber = Sum(num);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);


//Напишите программу, которая задаёт массив из произвольного элементов и выводит их на экран.

Console.Write("Введите количество элементов массива:\t");

int Count = int.Parse(Console.ReadLine());
    int[] array = new int[Count];
    for (int i = 0; i < array.Length; i++){
        Console.Write($"Введите элемент массива под индексом {i}: ");
        array[i] = int.Parse(Console.ReadLine());
    }
   
Console.WriteLine("Вывод массива: ");
    Console.Write("[ ");
    for(int i = 0; i<array.Length; i++){
        Console.Write(array[i]+", ");
    }
    Console.Write("]");


*/    