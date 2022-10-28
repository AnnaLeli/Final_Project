
string[] array = new string[8]{"1234", "1567", "-2", "computer science", "Hello", "2", "world", ":-)"};
Console.Write("Начальный массив: ");
PrintArray(array);
string[] arrayNew = new string[array.Length];
Console.WriteLine();
int count = 0;
for (int index = 0; index < array.Length; index++)
    {
    if(array[index].Length <= 3)
        {
        arrayNew[count] = array[index];
        count++;
        }
    }
void PrintArray(string[] arrayNew)
{
    for (int index = 0; index < arrayNew.Length; index++)
    {
        Console.Write($"{arrayNew[index]} ");
    }
}

Console.Write("Итоговый массив: ");
PrintArray(arrayNew);
