// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();
Console.Write("Введите любые числа(через запятую): ");
int[] enterNum=Console.ReadLine().Split(",").Select(int.Parse).ToArray();
Console.WriteLine("Больше нуля "+startProgram(enterNum)+" числа");

int startProgram(int[] enterNum)
{
   int result=0; 
   for (int i=0;i<enterNum.Length;i++)
      {
         if (enterNum[i] > 0) {result+=1;} 
      }
   return result;
}

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
Console.Write("Введите координаты точек b1,k1,b2,k2: ");
int[] points=Console.ReadLine().Split(",").Select(int.Parse).ToArray();
StartProgram(points);

void StartProgram(int[] points)
{
   double b1=points[0], k1=points[1],b2=points[2],k2=points[3];
   double result=(b2 -b1)/(k1-k2);
   Console.WriteLine($"Точка пересечения: {result} {k1*result+b1}");

}

