/*Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
 void StartProgram(int num)
 {
     //Определяю разрядность введённого числа округляю вниз до целой части числа Log10(num)
     int CheckingBitDepth=1+(int)Math.Log10(num); 
     if (CheckingBitDepth < 5 | CheckingBitDepth > 5) {Console.Write("Вы не ввели пятизначное число! ");}
     else
     {
         //определяем первую, вторую, предпоследнюю и последнюю цифру входного числа
         int a1 = (num % 100000) / 10000 ; 
         int a2 = (num % 10000) / 1000; 
         int a3 = (num % 100) / 10; 
         int a4 = (num % 10); 
         //сравниваеи первую, вторую, предпоследнюю и последнюю цифру входного числа
         if (a1 == a4 & a2 == a3) {Console.WriteLine("Данное число является палиндромом.");}
         else {Console.WriteLine("Число не является палиндромом");}
     }  
 }

 while(true)
 {
 Console.Write("Введите пятизначное число(для выхода введите exit): ");
 string text=Console.ReadLine();
 if (text.Equals("exit")) {Console.Clear(); System.Environment.Exit(0);}
 if (int.TryParse(text, out int num))
 { StartProgram(num);} else {Console.WriteLine("Вы не ввели число! Введите пожалуйста пятизначное число. Для его проверки является ли оно палиндромом");}
 }
 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
Изменяю представление пользовательского языка системы по умолчанию так как представление дробного числа по умолчанию ",",
а мне нужна ".
*/
/*Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//Изменяю локацию культуры, региона (так как в русскоязычной локации, в числе с плавающей точкой проставляется , а нужна .)

Console.WriteLine("Введите координаты двух точек А и В лежащих в 3D пространстве по осям X,Y,Z. ");
//обьявляю массивы где буду храниться введёные значения пользователем 
double[] pointA=new double[3]; //[0] - x, [1] - y, [2] - z
double[] pointB=new double[3];
//Вызываю метод в котором пользователь вводит координаты точек
CompletionArray(pointA,pointB);
//Вызываю функцию расчёта расстояние между точками
double ResultDistance=Distance(pointA, pointB);
//результат 
Console.WriteLine("Расстояние между точками в 3D пространстве составляет: "+ResultDistance);
//метод заполнения обьявленных ранее массивов
void CompletionArray(double[] pointA,double[] pointB )
{
    Console.Clear(); //очищаю консоль
string RequestEnterPointA="Введите через запятую, координаты точки А лежащей на X,Y,Z(для ввода дробного числа используйте .): ";
Console.Write(RequestEnterPointA);
string[] EnterPointA = Console.ReadLine().Split(','); //каждый новый элемент массива EnterPointA будет после ","
int SizeArrayA=EnterPointA.Length; //измеряю массив введённых значений
    for (int i=0;i<SizeArrayA;i++) //проход циклом for
        {
            //проверю тип введёных данных если всё нормально пишу в массив XYZpointA  
            if (double.TryParse(EnterPointA[i], out double XYZpointA)) { 
                 pointA[i]=XYZpointA;
        } }
string RequestEnterPointB="Введите через запятую, координаты точки В лежащей на X,Y,Z(для ввода дробного числа используйте .): ";
Console.Write(RequestEnterPointB);
string[] EnterPointB = Console.ReadLine().Split(',');
int SizeArrayB=EnterPointB.Length;
    for (int i=0;i<SizeArrayB;i++)
    {
            if (double.TryParse(EnterPointB[i], out double XYZpointB)) { 
                    pointB[i]=XYZpointB;
        }
    } }
//функция расчёта расстояния между точками А и В
double Distance(double[] pointA, double[] pointB)
{
    double result; //обьяляю переменную которая будет хранить результат
    //формула расчёт расстояния между точкаи, использую Math класс имеющийся в C#
    result=Math.Sqrt(Math.Pow(pointB[0]-pointA[0],2)+Math.Pow(pointB[1]-pointA[1],2)+Math.Pow(pointB[2]-pointA[2],2) );
    return result; //возвращаю результат
}*/

/*Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Здравствуйте! Введите число N: ");
int numberN=Convert.ToInt32(Console.ReadLine()); //считываю значения с клавиатуры

StartProgram(numberN);
void StartProgram(int numberN)
{
    int count=1; //ставлю счётчик от 1
    while (count <=numberN) //если счётчик  меньше или равен введёному числу, то конец цикла
        {
            int rezult =(count*count*count); //перемножаю три раза count само на себя
            Console.WriteLine(rezult);
            count++; //увеличиваю значение счётчика
        }
}*/