//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] numbers = new int[9];

void NewArray(int[] array, int min, int max){
  for (int i = 0; i<array.Length; i++ ){
    array[i] = new Random().Next(min, max);
  }
}

void OutputArray(int[] array){
    for (int i = 0; i<array.Length; i++ ){
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

int PositiveNambers(int[] array){
    int quantity = 0;
    for (int i = 0; i<array.Length; i++ ){
    if (array[i] % 2 == 0)
    {
      quantity++;
    }
  }
  return quantity;
}

NewArray(numbers, 100, 1000);
OutputArray(numbers);
Console.WriteLine();

int quantity = PositiveNambers(numbers);
Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");


//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write($"Введите количество элементов массива: ");
int numberElements = Convert.ToInt32(Console.ReadLine()); 

int RandomNumbers(int numberElements, int min, int max)
  {
  int[] randomNumbers = new int[numberElements];
  int sumElements = 0;
  Console.Write("Новый массив: ");

    for (int i = 0; i <randomNumbers.Length; i++ ){
      randomNumbers[i] = new Random().Next(min, max);

      Console.Write(randomNumbers[i] + " ");

      if (i % 2 != 0)
      {
        sumElements = sumElements + randomNumbers[i];
      }
    }
  return sumElements;
  }

int randomNumbers =  RandomNumbers(numberElements, 1, 100);

Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {randomNumbers}");


//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

double[] Array = new double[10];
  for (int i = 0; i < Array.Length; i++ )
  {
    Array[i] = new Random().Next(1, 100);
    Console.Write(Array[i] + " ");
  }

double maxNumber = Array[0];
double minNumber = Array[0];

  for (int i = 1; i < Array.Length; i++)
  {
    if (maxNumber < Array[i])
    {
      maxNumber = Array[i];
    }
        if (minNumber > Array[i])
    {
      minNumber = Array[i];
    }
  }

  double difference = maxNumber - minNumber;

  Console.WriteLine($"\nразница между максимальным элементом массива ({maxNumber}) и минимальным элементом массива ({minNumber}) равна: {difference}");


  */