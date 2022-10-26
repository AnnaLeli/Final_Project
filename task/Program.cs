
string[] array = new string[8]{"1234", "1567", "-2", "computer science", "Hello", "2", "world", ":-)"};
void Result(string[] array)
{
for (int index = 0; index < array.Length; index++)
    {
    if(array[index].Length <= 3)
        {
    //    arrayShort[index] = array[count];
        Console.Write($"{array[index]} ");
    //    count++;
        }
    }
}
Result(array);