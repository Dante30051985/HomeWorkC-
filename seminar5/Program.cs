/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Clear();
Console.Write("Введите размер массива: ");
int enterNum=int.Parse(Console.ReadLine());

Parity(CreateRandomThree(enterNum));
void Parity(int[] array)
{    int result=0;
     Console.Write("Случайнные положительные числа: ");  
     for (int i=0;i<array.Length;i++) //прохожу циклом по массиву
     {  Console.Write($"{array[i]} ");
        if (array[i]%2 == 0) { //проверяю делится ли на 2(значит чётное)
            result+=1;
            }
     }  
     Console.WriteLine("");
     Console.WriteLine($"Количество чётных чисел в массиве:{result}");
}

int[] CreateRandomThree(int enterNum)
{
    int[] array=new int[enterNum]; //заданная длина массива пользователем
    Console.Write("Введите элементы массива: ");  
    //считываю значения в консоли, новый элемент массива numbers[] будет через запятую
    int[] numbers=Console.ReadLine().Split(',').Select(s=>int.Parse(s)).ToArray();
    //прохожу циклом и заполняю его
    for (int ind=0;ind<enterNum;ind++)
    { array[ind]=numbers[ind];}
    return array;
}*/
/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();
Console.Write("Введите размер массива: ");
int enterNum=int.Parse(Console.ReadLine());

OddSum(CreateRandom(enterNum));

void OddSum(int[] array)
{    int result=0;
     for (int i=0;i<array.Length;i++) //прохожу циклом по массиву
     {  
        if (i%2 !=0) {
            result+=array[i];
            } 
     }  
     Console.WriteLine("");
     Console.WriteLine($"Сумма нечётных элементов в массиве:{result}");
}

int[] CreateRandom(int enterNum)
{
    int[] array=new int[enterNum]; //заданная длина массива пользователем
    Console.Write("Введите элементы массива: ");  
    //считываю значения в консоли, новый элемент массива numbers[] будет через запятую
    int[] numbers=Console.ReadLine().Split(',').Select(s=>int.Parse(s)).ToArray();
    //прохожу циклом и заполняю его
    for (int ind=0;ind<enterNum;ind++)
    { array[ind]=numbers[ind];}
    return array;
}*/
/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();
Console.Write("Введите размер массива: ");
int enterNum=int.Parse(Console.ReadLine());

DifferenceMinMax(CreateRandom(enterNum));

void DifferenceMinMax(double[] array)
{   
     double min=array[0];
     double max=array[0];

     for (int i=0;i<array.Length;i++) //прохожу циклом по массиву
     {  
        if (array[i]>max) {max=array[i];}
        if (array[i]<min) {min=array[i];}
     }  
  double result=max-min;
     Console.WriteLine("");
     Console.WriteLine($"Минимальный элемент в массиве {min}, максимальный {max}");
     Console.WriteLine("");
     Console.WriteLine($"разница между максимальным и минимальным элементом массива:{result}");
}

double[] CreateRandom(int enterNum)
{
    double[] array=new double[enterNum]; //заданная длина массива пользователем
    Console.Write("Введите элементы массива: ");  
    //считываю значения в консоли, новый элемент массива numbers[] будет через запятую
    int[] numbers=Console.ReadLine().Split(',').Select(s=>int.Parse(s)).ToArray();
    //прохожу циклом и заполняю его
    for (int ind=0;ind<enterNum;ind++)
    { array[ind]=numbers[ind];}
    return array;
}*/










