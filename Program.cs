Console.Clear();
Console.WriteLine("Введите исходный массив строк, разделяя элементы запятой:");
string[] inputArray = Console.ReadLine()!.Split(',');

int count = 0;
string[] newArray = new string[inputArray.Length];

for (int i = 0; i < inputArray.Length; i++)
{
    string trimmed = inputArray[i].Trim();
    if (trimmed.Length <= 3)
    {
        newArray[count] = trimmed;
        count++;
    }
}

Array.Resize(ref newArray, count);

Console.Write("Результат: ");
for (int i = 0; i < count; i++) {
    Console.Write(newArray[i] + " ");
}