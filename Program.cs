Console.Clear();
Console.WriteLine("Введите исходный массив строк, разделяя элементы запятыми:");
string[] inputArray = Console.ReadLine()!.Split(',');

int count = 0;
string[] newArray = new string[inputArray.Length];

for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray
[i].Length <= 3)
    {
        newArray[count] = inputArray
    [i];
        count++;
    }
}

Array.Resize(ref newArray, count);

Console.WriteLine("Результат:");
foreach (string s in newArray)
{
    Console.WriteLine(s);
}

Console.ReadLine();