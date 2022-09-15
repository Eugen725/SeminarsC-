// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*

Console.Write("Введите число строк массива (m): "); 
int m = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите число столбцов массива (n): "); 
int n = Convert.ToInt32(Console.ReadLine());  

Console.WriteLine( );

double[,] array = new double[m,n];

void CreateArray(double[,] array){
     for (int i = 0; i < m; i++){
         for (int j=0; j<n; j++){
            array[i, j] = new Random().NextDouble() * 10 - 3;
            }
         }
     }

void ShowMe2dArray(double[,] array){
for (int i = 0; i < m; i++){
      for (int j = 0; j < n; j++){
        double alignNumber = Math.Round(array[i, j], 1);
        Console.Write(alignNumber + " ");
        }
        Console.WriteLine();     
    } 
}  

CreateArray(array); 
ShowMe2dArray(array);


//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите число строк массива (m): "); 
int m = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите число столбцов массива (n): "); 
int n = Convert.ToInt32(Console.ReadLine());  

Console.WriteLine( );

int[,] array = new int[m, n];
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(0,21));  
}
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "\t");
        Console.WriteLine();
}
 
 Console.WriteLine( );
 
 Console.Write("Введите позицию элемента (i): ");
 int a = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите позицию элемента (j): ");
 int b = Convert.ToInt32(Console.ReadLine());

 if (a>m && b>n)
 Console.WriteLine("Элемент с введенными позициями не существует");
 else
 {
 object c = array.GetValue(a,b);
 Console.WriteLine($"Элемент массива с введенными позициями: {c}");
 }


//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandom2dArray(int rows, int cols, int min, int max){
    int[,] array = new int[rows,cols];
    for(int i = 0; i<rows; i++)
        for(int j = 0; j<cols; j++)
            array[i,j] = new Random().Next(min, max+1);
    return array;
}

void Show2dArray(int[,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}

void AverageCols(int[,] array){
    double average = 0;
    double sum = 0;
        for(int cols = 0; cols<array.GetLength(1); cols++){
            for(int rows = 0; rows<array.GetLength(0); rows++){
                sum += array[rows, cols];
                average = sum / (array.GetLength(0));
                }
        double average2 = Math.Round(average, 1);
        Console.WriteLine($"Arithmetic mean of a column {cols} is: {average2}");
        sum = 0;
        }
    }

Console.Write("Input numb of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of max: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,] array = CreateRandom2dArray(rows,cols,min,max);
Show2dArray(array);
Console.WriteLine();
AverageCols(array);


*/