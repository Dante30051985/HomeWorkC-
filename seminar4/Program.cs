/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int StartProgram(int[] enterNum)
{
   int number_a=enterNum[0]; //число A
   int natural_degre=enterNum[1]; //натуральная степень В
   int result=enterNum[0]; //храню результат

    //прохожу циклом от 1 до ввёдной степени
   for (int curr=1;curr<natural_degre;curr++)
   {    
        result=result*number_a;
   }
    return result;
}
Console.Clear();
Console.Write("Введите через запятую, число А и его степень(число В): ");
//записываю в массив введённые значение в консоли, разделителем переменных служит запятая
//выбираю преобразованное строковое значение из консоли, в представлении числа, и заполняю массив enterNum
int[] enterNum=Console.ReadLine().Split(',').Select(int.Parse).ToArray();
int result=StartProgram(enterNum);
Console.WriteLine($"Число {enterNum[0]} в степени {enterNum[1]}, будет иметь ответ:{result}");
*/

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int SummaNumber(int enterNum)
{
    int result=0; //храню результат

    //прохожу циклом если введённое число не равно нулю
    //введёное число делю на 10 для поиска 
    остатка
    //разделёное число возвращается в цикл и снова делится на 10
    for (; enterNum != 0; enterNum/=10) { result += enterNum % 10; }
   
    return result;
}

Console.Write("Введите любое двух, трёхзначное число и посчитаю сумму его цифр: ");
int enterNum=Convert.ToInt32(Console.ReadLine());
int result=SummaNumber(enterNum);
Console.WriteLine(result);*/

//Задача 29: Напишите программу, которая задаёт массив из произвольного элементов и выводит их на экран.
 int[] ArrayInit(int enterNum)
 {
   int[] array=new int[enterNum]; //задаю размер массива введённым знчением с клавиатуры
  
 //  прохожу циклом и заполняю массив array
  for (int i=0;i<enterNum;i++)
  {
      Console.WriteLine($"Элемент {i} значение:");
      array[i]=int.Parse(Console.ReadLine()); //преобразую строку в int
  }
    return array;
}

 void OutScreenArray(int[] array)
 {
 Console.Write("Массив содержит элементы:[");
    for (int i=0;i<array.Length;i++) //прохожу циклом по массиву и вывожу его значения
    {   Console.Write(" "+array[i]+" ");   }
Console.Write(" ]");
 }

Console.Write("Введите число, для задания массива: ");
int enterNum=int.Parse(Console.ReadLine());
//вызов метода вывод массива на экран(в нём в качестве параметра передаю что сначала вызвать функцию заполнения массива)
OutScreenArray(ArrayInit(enterNum)); 