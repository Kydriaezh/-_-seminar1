// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
string Thnum (int num)
        {
            string result = "нет третьей цифры";
            if (num > 99)
            {
                while (num > 999)
                {
                    num = num / 10;
                }
                result = $"{num % 10}";
               
            }
            return result; 
        }
Console.WriteLine(Thnum(num));   

 
 
 
 
 


