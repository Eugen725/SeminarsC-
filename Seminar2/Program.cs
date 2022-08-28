//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
/*
int CutNumber(){
    int num = new Random().Next(100, 1000);
    Console.WriteLine("Number is - " + num);
    int dec = num % 100;
    int result = dec/10;
    return result;
}

int number = CutNumber();
Console.WriteLine("Two number is - " + number);


//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void ThreeNumber(){
int Number = Convert.ToInt32(Console.ReadLine());
string NumberText = Convert.ToString(Number);
   if (NumberText.Length > 2){
       Console.WriteLine("третья цифра " + NumberText[2]);
    }
   else {
       Console.WriteLine("третьей цифры нет");
    }
}

Console.Write("Введите число: ");
ThreeNumber();


//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

void DayWeek (int Number) {
  if (Number == 6 || Number == 7) {
  Console.WriteLine("Да, этот день выходной");
  }
  else if (Number < 1 || Number > 7) {
    Console.WriteLine("Неверное число");
  }
  else Console.WriteLine("Нет, этот день не выходной");
}

Console.Write("Введите цифру, соответствующую дню недели: ");
int Number = Convert.ToInt32(Console.ReadLine());
DayWeek(Number);


*/