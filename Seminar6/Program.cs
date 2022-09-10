// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.Write($"Введите M (количество чисел): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] arrаyNumbers = new int[m];

void InputNumbers(int m){
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введите {i+1} число: ");
    arrаyNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Calculation(int[] arrаyNumbers)
{
  int count = 0;
  for (int i = 0; i < arrаyNumbers.Length; i++)
  {
    if(arrаyNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(m);

Console.WriteLine($"Количество чисел больше ноля: {Calculation(arrаyNumbers)} ");


// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double[,] meaning = new double[2, 2];
double[] crossPoint = new double[2];

void InputMeanings(){
  for (int i = 0; i < meaning.GetLength(0); i++)
  {
    Console.Write($"Введите значения {i+1}-го уравнения (y = k * x + b):\n");
    for (int j = 0; j < meaning.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите значение k: ");
      else Console.Write($"Введите значение b: ");
      meaning[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Decision(double[,] meaning)
{
  crossPoint[0] = (meaning[1,1] - meaning[0,1]) / (meaning[0,0] - meaning[1,0]);
  crossPoint[1] = crossPoint[0] * meaning[0,0] + meaning[0,1];
  return crossPoint;
}

void Response(double[,] meaning)
{
  if (meaning[0,0] == meaning[1,0] && meaning[0,1] == meaning[1,1]) 
  {
    Console.Write($"\nПрямые совпадают");
  }
  else if (meaning[0,0] == meaning[1,0] && meaning[0,1] != meaning[1,1]) 
  {
    Console.Write($"\nПрямые параллельны");
  }
  else 
  {
    Decision(meaning);
    Console.Write($"\nТочка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
  }
}

InputMeanings();
Response(meaning);

*/