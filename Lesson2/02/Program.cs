// Напишите программу, которая выводит случайное трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.


//int Maxnumber(int num)
//{
  
//   return num % 10;
//}
//Console.WriteLine(Maxnumber(new Random().Next(100, 1000)));

int num = new Random().Next(100, 1000);
Console.WriteLine(num % 10);
