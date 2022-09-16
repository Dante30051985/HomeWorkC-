/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.*/
Console.Clear();
Console.Write("Введите значения M и N:"+"\t");
int[] enterNum=Console.ReadLine().Split(",").Select(int.Parse).ToArray();
int m=enterNum[0], n=enterNum[1];
Recursion(m,n);
//функция рекурсии
int Recursion(int m, int n)
{   if (m>=n+1) 
    { return 0; }
      else {
 Console.Write(m+"\t");
    return Recursion(m+1, n);}
}

/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Clear();
Console.Write("Введите значения M и N(через запятую):"+"\t");
int[] enterNum=Console.ReadLine().Split(",").Select(int.Parse).ToArray();
int m=enterNum[0], n=enterNum[1], summa=n;
Recursion(m,n,summa);
//функция рекурсии
int Recursion(int m, int n, int summa)
{ if (m>n) { return 0; } else { Console.Write(summa+"\t"); return Recursion(m, n-=1, summa+n);}}*/

/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
Console.Clear();
Console.Write("Введите два неотрицательных числа M и N(через запятую):"+"\t");
int[] enterNum=Console.ReadLine().Split(",").Select(int.Parse).ToArray();
int m=enterNum[0], n=enterNum[1], res=0;
int result=Akkerman(m,n);
Console.Write("A("+$"{m},{n})={m}{result}");

int Akkerman(int m,int n){
    if (m==0){ return n+1; } else 
    if((m>0) && (n==0)){ 
        return Akkerman(m-1,1);} 
        else if ((m>0) && (n>0)){
            return Akkerman(m-1, Akkerman(m,n-1));
    }
    return 0;
 }*/
