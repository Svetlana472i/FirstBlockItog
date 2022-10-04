Console.WriteLine("Сколько элементов строкового массива вы хотите ввести?");
bool isNumber = int.TryParse(Console.ReadLine(), out int m);
if (isNumber == false || m<=0)
{
    Console.WriteLine("Число введено неверно");
    return;
}

string[] inputArray = new string[m];
int count = 0;

string[] FillArray(int m)
{
     int length = m;
    for (int i = 0; i < length; i++)
    {
      Console.WriteLine($"Введите {i+1}-й элемент массива");
      inputArray[i] = Console.ReadLine();    
      if (inputArray[i].Length <= 3)
      {
        count++;
      }
}
    return inputArray; 
}

string[] FillArray2(string[] array)
{
    string[] array1 = new string[count];
    int count1 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array1[count1] = array[i];
            count1++;
        }
    }
    return array1;
}

void PrintArray(string[] arr)
{   int n = arr.Length;
    Console.Write("[");
    for (int i = 0; i < n-1; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.WriteLine($"{arr[n-1]}]");
}
string[] inpArray = FillArray(m);
string[] outpArray = FillArray2(inpArray);
Console.Write("Вы ввели следующий массив строк: ");
PrintArray(inpArray);
if (count==0)
{
    Console.WriteLine("Вы не ввели ни одного элемента массива не превышающего 3-х символов");
}
else
{
    Console.Write("Длина следующих строк не превышает 3-х символов: ");
PrintArray(outpArray);
}
