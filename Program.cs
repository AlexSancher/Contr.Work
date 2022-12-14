void FillArray(string[] newArray) // эта функция создает массив с типом string и дает возможность пользователю вносить в него элементы с клавиатуры
{
    System.Console.Write("Задайте элементы массива:  ");
    for (int i = 0; i < newArray.Length; i++)
    {
        System.Console.Write($"[{i}]"); ;
        newArray[i] = Console.ReadLine()!;
    }

}

void PrintArray (string[] arrayToPrint) // эта функция печатает массив
{
    Console.ForegroundColor=ConsoleColor.Green;
    Console.WriteLine("---------------------------");
    Console.ForegroundColor=ConsoleColor.White;
    Console.Write("[");
    for (var i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if(i != arrayToPrint.Length -1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
    Console.ForegroundColor=ConsoleColor.Green;
    Console.WriteLine("---------------------------");
    Console.ForegroundColor=ConsoleColor.White;
    Console.WriteLine();
}

string[] FindShortElement(string[] shortElement) // эта функция находит короткие элементы в исходном массиве и заполняет ими итоговый массив
{

    int count = 0;
    string element = String.Empty;
    for (int i = 0; i < shortElement.Length; i++)
    {
        element = shortElement[i];
        if (element.Length < 4)
        {
            count++;
        }
    }
    string[] resultArray = new string[count];
    count = 0;
    for (int i = 0; i < shortElement.Length; i++)
    {
       
        element = shortElement[i];
        if (element.Length <= 3)
        {
            resultArray[count] = element;
            count++;
        }
    }
    return resultArray;
}

System.Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
string[] array = new string[sizeArray];
FillArray(array);
string[] resultArray = FindShortElement(array);
Console.WriteLine("Исходный массив: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Итоговый массив");
PrintArray(resultArray);