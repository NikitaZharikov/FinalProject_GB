string[] array1 = new string[]
    { "123", "23", "hello", "world", "Denmark", "1234", "Russia", "-2" };

string[] array2 = new string[array1.Length];

void CreateSecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}

CreateSecondArray(array1, array2);
PrintArray(array2);