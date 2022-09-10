/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Clear();
Console.Write("Введите через запятую, размер матрицы (MxN) : ");
int[] enterNum=Console.ReadLine().Split(",").Select(int.Parse).ToArray();
double[,] array=new double[enterNum[0], enterNum[1]];
ShowResult(array);

void ShowResult(double[,] array)
{  
    var r = new Random();
    for (int i=0;i<array.GetLength(0);i++)
      { Console.WriteLine(" ");
     for (int j=0;j<array.GetLength(1);j++)
            {
                array[i,j]=(double)r.Next(-10,10)/2;

                Console.Write(array[i,j]+" ");
            }
      }
}*/
/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Clear();
int row=3, col=4; //размерность матрицы
int min=0, max=10; //минимум макасимум для генерация случайных чисел
int[,] array = new int [row, col]; //инициализирую массив матрицы
array=CreateRnd(row,col,min,max); //заполняю его

Console.Write($"Введите позицию элемента матрицы {row}:{col} (строка,столбец) через запятую ->"+"\t");
int[] enterNum=Console.ReadLine().Split(",").Select(int.Parse).ToArray();

PrintResult(enterNum,array);

void PrintResult(int[] enterNum, int[,] array)
{
    int PositionRow=enterNum[0]; int PositionCol=enterNum[1]; //ложу в переменные позиции массива
    int rowsArray=array.GetLength(0); int colsArray=array.GetLength(1); //ложу размерности массива
    int resultCol=0; //результат поиска по стобцам
    int resultRow=0; //результат поиска по строкам

    if (PositionCol < colsArray  && PositionRow < rowsArray) //проверка если введёная позиция меньше размера матрицы
    {
    for (int i=0;i<rowsArray;i++) //иду циклом
        {
            Console.WriteLine(); //разрыв
                if (PositionRow == i) resultRow=i; //если позиция по строке совпадает с позицией столба матрицы то ложу в resultRow
            for (int j=0;j<colsArray;j++)
            {
                if (PositionCol == j) resultCol=j; //если совпадает по столбцу то ложу в resultCol
                Console.Write(array[i,j]+"\t"); //\t табуляция для наглядности выведенной матрицы
            }
        }
    Console.WriteLine(); //разрывы
    Console.WriteLine();
    
    Console.Write($"Элемент найден столбец индекс - {resultCol}, строка индекс - {resultRow} значение элемента {array[resultRow, resultCol]}");
    } else {Console.Write("не такого элемента в матрице!");}
}

int[,] CreateRnd(int row,int col, int min, int max)
{  
    for (int i=0;i<row;i++)
        { for(int j=0;j<col;j++)
            { array[i,j] = new Random().Next(min,max); }   
                 }
    return array;
}*/
/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.*/
Console.Clear();
Console.WriteLine("Задайте матрицу, чтобы посчитать её среднееарифмитическое по столбцам");
Console.Write("Введите размерность матрицы, через запятую: ");
int[] sizeArray=Console.ReadLine().Split(",").Select(int.Parse).ToArray();


PrintResult(CreateArray(sizeArray));

void PrintResult(int[,] array)
{
int rows = array.GetLength(0); //кладу 1 и 2 размерность в массив 
int columns = array.GetLength(1); 
double[] columnAmounth = new double[columns]; //инициализирую массив где будет хранится результат сложения чисел
    for (int i = 0; i < rows; i++){ //прохожусь циклом по строкам
            Console.WriteLine(); //делаю новую строку
            for (int j = 0; j < columns; j++) //прохожу циклом по столбцам
                {
                    columnAmounth[j] += array[i, j]; //ложу в массив суммированной значение столбца 
                    Console.Write($"{array[i, j]}\t"); //показываю сформированную матрицу `\t` - универсальная последовательность представляющая табуляцию
                }
            }
Console.WriteLine();
Console.WriteLine();

for (int j = 0; j < columns; j++) //иду циклом по кол-ву столбцов
    {   double average=columnAmounth[j]/rows; //делю на количество строк
        Console.Write(Math.Round(average, 2)+"\t"); //округляю результат деления, 2 означает кол-во знаков после ,
     }
            
}

int[,] CreateArray(int[] sizeArray)
{
    int[,] array=new int[sizeArray[0],sizeArray[1]];
        for ( int i=0;i<array.GetLength(0);i++)
            { for (int j=0;j<array.GetLength(1);j++) 
                { Console.Write($"Элемент строки {i}, столбца {j}: ");  
                  array[i,j]=int.Parse(Console.ReadLine());
                   }
            
            } 
 return array;
}