//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.Write("Введите пятизначное число: ");
string? num = Console.ReadLine();

void CheckingPalindrome(string num){
  if (num[0]==num[4] || num[1]==num[3]){
    Console.WriteLine("Число палиндром");
  }
  else Console.WriteLine("Число не палиндром");
}

if (num!.Length == 5){
  CheckingPalindrome(num);
}
else Console.WriteLine($"Число не пятизначное");


//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine();
int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string cdName, string ptName)
{
    Console.Write($"Введите координату {cdName} точки {ptName}: ");
    return Convert.ToInt32(Console.ReadLine());
}

double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double distance = Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Расстояние между точками {distance}");



//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube){
  int num = 0;
  int i = cube.Length;
  while (num <  i){
    cube[num] = Convert.ToInt32(Math.Pow(num, 3));
    num++;
  }
}

void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  while(index < count){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);


*/