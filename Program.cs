string[] SortArray(string[] array)
{
    int size = array.Length;
    string[] empty = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            empty[i] = array[i];
        }
        else
        {
            size = size - 1;
        }
            
    }
    return empty;
}

Console.Clear();
string[] array = new string[] {"all", "my", "friends", "are", "toxic", "all", " ambitionless"};
string[] rezult = SortArray(array);
Console.Write("Выводим массив: ");
Console.WriteLine("[" + string.Join(", ", array) + "]");

Console.Write("Элементы длины 3 или меньше: ");
rezult = rezult.Where(x => x != null).ToArray();
System.Console.WriteLine("[\"" + string.Join("\", \"", rezult) + "\"]");