/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.Clear();
Console.Write("Задайте размерность матрицы (через запятую):\t");
int[] sizeMatrix=Console.ReadLine().Split(",").Select(int.Parse).ToArray();
StartProgram(createMatrixArray(sizeMatrix));
void StartProgram(int[,] array) //метод вывода сгенерированной матрицы заданой размерности из консоли 
{   int row=array.GetLength(0); int col=array.GetLength(1);
    Console.WriteLine();
    Console.WriteLine($"Сгенерированная матрица {row} на {col} ");
    for (int i=0;i<row;i++)
        {   Console.WriteLine();       
            for (int j=0;j<col;j++)
                { Console.Write(array[i,j]+"\t");}
        }
    SortingRow(array, row, col); //метод вызова сортировки, и показ в консоли
}

void SortingRow(int[,] array, int row, int col) //передаю 2D массив и его размерность
{   Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"Сортировка(убывание) по строкам матрицы {row} на {col}");
    int temp=0; //временная переменная
    for (int i=0;i<row;i++) //иду по строкам
    {    for (int j=1;j<col;j++) // по столбцам
        {   for (int k=col-1;k>=j;k--){ //цикл сортировки пузырьком
                     if(array[i,k-1] < array[i,k])  //если пердыдущее значение строки меньше текущего то меняю местами
                    {   temp=array[i,k-1];
                        array[i,k-1]=array[i,k];
                        array[i,k]=temp;                }
            }
        }
    }
    for (int l=0;l<row;l++)
    {   Console.WriteLine();
        for (int u=0;u<col;u++)
        { Console.Write(array[l,u]+"\t");
        }  } }

int[,] createMatrixArray(int[] sizeMatrix)
{
    int[,] array=new int[sizeMatrix[0],sizeMatrix[1]];
    
        for (int i=0;i<array.GetLength(0);i++){
            for (int j=0;j<array.GetLength(1);j++)
            {   array[i,j]=new Random().Next(1,10);}
        } 
    return array;
}
*/
/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.Clear();
int[,] array = CreateArray();
PrintArray(array);
void PrintArray(int[,] array)
{ int row=array.GetLength(0), col=array.GetLength(1);
 for (int i=0;i<row;i++){
        Console.WriteLine();
    for (int j=0;j<col;j++){
         Console.Write(array[i,j]+"\t");
    } }
CalcRowArray(array);}
void CalcRowArray(int[,] array)
{   int row=array.GetLength(0), col=array.GetLength(1);
    int[] result=new int[row];  
    for (int i=0; i<row; i++){
        for (int j=0; j<col; j++)
                 { result[i] +=array[i,j];}
            Console.WriteLine();
            Console.Write($"Сумма {i+1} строки равна: {result[i]}"+"\t");
            }
////////////////////////////////////////////////////
    Console.WriteLine();
    int minValue=result[0], index=1;
    for (int i=0;i<result.Length;i++)
    {        if (result[i]<minValue){ //если значенье текущее минимальное больше текущего i то кладу в массив
            minValue=result[i];
            index=i+1; //индекс в перемнную складываю
        }
    }
Console.WriteLine();
Console.Write($"в {index} строке обнаружена строка с минимальной суммой {minValue}");
}
int[,] CreateArray()
{   Console.Clear();
    int[,] arr=new int[4,4];
    int row=arr.GetLength(0), col=arr.GetLength(1);
    Console.WriteLine("Введите элементы матрица 4:4");
    for (int i=0; i<row;i++)
    {   for (int j=0; j<col; j++)
        {
            arr[i,j]=new Random().Next(1,10);
            arr[j,i]=new Random().Next(1,10);
        }                      
    }         
    return arr;
} */
/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
 int size=4; //переменная кол-во строк и столбцов(размерность)

ShowSpiralMatrix(CreateArrSpiral(size));
void ShowSpiralMatrix(int[,] matrix)
{   for (int i=0; i<matrix.GetLength(0);i++){
        Console.WriteLine();
        for (int j=0; j<matrix.GetLength(1);j++)
            { Console.Write(matrix[i,j]+"\t");        }
    }
}
 int[,] CreateArrSpiral(int size)
 {  int[,] matrix=new int[size,size]; //зададим размерность массива
    int row=matrix.GetLength(0), col=matrix.GetLength(1), max=0;
//По мере прохождения сторон "квадрата" мы проходим 4 итерации, в ходе которых проходим N элементов нашего массива. 
//Это повторяется, пока не закончатся "квадраты", то есть N/2 (при этом, если N нечетное, то округление должно 
//производиться в большую сторону) раз.
    while (Math.Round((double)col/2)>0) {
        for (int i=0;i<row;i++){
            for (int j=0;j<col;j++){
                if (i==0 && j<col-max) {
                    Console.Write($"Введите элемент {i},{col-max}: ");
                    matrix[i+max,j+max]=int.Parse(Console.ReadLine());
                }
                if (j != 0) {
                if (i == 2 && j < col - max){
                    int r=col-(j+1);
                    Console.Write($"Введите элемент {i},{r}: ");
                    matrix[col - 1, r]=int.Parse(Console.ReadLine());
                }
                if (i == 1 && j < col - max) {
                    Console.Write($"Введите элемент {i},{col-max}: ");
                    matrix[j+max, col-1] = int.Parse(Console.ReadLine());
                }
                if (i == 3 && j < col - (max+1))
                {   Console.Write($"Введите элемент {i},{col-(max+1)}: ");
                    matrix[col-(j+1),max]=int.Parse(Console.ReadLine());
                }
                }
            }
        }
    col--;
    max++;
    }
    return matrix;
 }*/
                
    
