// Задача 15:
 Console.Write(" Введите номер дня: ");
 int n = Convert.ToInt32(Console.ReadLine());
 if (n > 7 || n < 1)
 {
    Console.WriteLine("попробуй еще ");
 }
  if (n == 6 || n == 7)
 {
    Console.WriteLine("Ехуу, выходной!"); 
 }
 if (n < 6 )
 {
    Console.WriteLine("Будни;( ");
 } 

     

