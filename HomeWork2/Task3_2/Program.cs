// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Заклинило меня");
int num = int.Parse(Console.ReadLine());

    if (num < 100)   
    Console.WriteLine("no");    
        {
            while (num > 999)
            { 
                num = num / 10; 
            }
            Console.WriteLine(num % 10); 
        }
       
    
   




// while (num > 999)
 { 
    num = num / 10; 
 } 
//ьConsole.WriteLine(Xz(num % 10));      

 
 
 
 
 


