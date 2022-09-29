/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/
StartProgram();

void StartProgram()
{
    Console.Clear();
    Console.Write("Введите любые слова:"+"\t");
    string[] enterArray = Console.ReadLine().Split(",").ToArray();
    PrintEnterArray(enterArray);
    Console.WriteLine();
    string[] result= NewArray(enterArray);
    PrintResult(result);
}

string[] NewArray(string[] enterArray)
{
    string[] narray=new string[enterArray.Length];
    for (int i=0;i<enterArray.Length;i++)
        { if (enterArray[i].Length<=3)
                { narray[i] = enterArray[i]; } }
    return narray;
}

void PrintResult(string[] result)
{
    for (int i=0;i<result.Length;i++)
    { Console.Write("['"+result[i]+"']"+"\t"); }    
}

void PrintEnterArray(string[] enterArray)
{
     for (int i=0;i<enterArray.Length;i++)
        { Console.Write("['"+enterArray[i]+"']"+"\t");}
}
