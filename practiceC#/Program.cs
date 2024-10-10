

Random random = new Random();
int[] randomNumbers = new int[20];
int[] randomNumbers2 = new int[10];
int[] randomNumbers3 = new int[15];

for (int i = 0; i < randomNumbers.Length; i++)
{
    randomNumbers[i] = random.Next(1, 101);
}
for (int i = 0; i < randomNumbers2.Length; i++)
{
    randomNumbers2[i] = random.Next(1, 101);
}
for (int i = 0; i < randomNumbers3.Length; i++)
{
    randomNumbers3[i] = random.Next(1, 101);
}
Console.WriteLine("Массив случайных чисел:");
foreach (int num in randomNumbers)
{
    Console.Write(num + " ");
}
Console.Write("\n");

int uniqueCounter = 0;
int evenCounter = 0;
int oddCounter = 0;
for (int i = 0; i < randomNumbers.Length; i++)
{
    int unique = randomNumbers[i];
    if (unique % 2 == 0)
        evenCounter++;
    else
        oddCounter++;
    for (int j = i+1; j < randomNumbers.Length; j++)
    {
        if (unique == randomNumbers[j])
            break;
        if (j == randomNumbers.Length - 1)
            uniqueCounter++;
    }
}
Console.WriteLine($"Уникальные значения:{uniqueCounter} ");
Console.WriteLine($"Четные значения:{evenCounter} ");
Console.WriteLine($"Нечетные значения:{oddCounter} ");

int lessThan( int[] arr)
{
    Console.Write("Введите число: ");
    int a = int.Parse(Console.ReadLine());
    int counter = 0;
    foreach (int b in arr)
    {
        if (b < a)
            counter++;
    }
    return counter;
}
Console.WriteLine($"Кол-во значений в массиве меньше заданого: {lessThan(randomNumbers)}");

int howMuchSubsequence(int[] arr)
{
    int counter = 0;
    Console.Write("Введите 1-ое число: ");
    int a1 = int.Parse(Console.ReadLine());
    Console.Write("Введите 2-ое число: ");
    int a2 = int.Parse(Console.ReadLine());
    Console.Write("Введите 3-ое число: ");
    int a3 = int.Parse(Console.ReadLine());
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == a1 && arr[i + 1] == a2 && arr[i + 2] == a3)
        {
            counter++;
            i += 3;
        }
    }
    return counter;
}
Console.WriteLine($"Кол-во вхождений заданной последовательности: {howMuchSubsequence(randomNumbers)}");

void commonNumbers(int[] arr, int[] arr2)
{
    Console.WriteLine("1-ый Массив:");
    foreach (int num in arr)
    {
        Console.Write(num + " ");
    }
    Console.Write("\n");
    Console.WriteLine("2-ый Массив:");
    foreach (int num in arr2)
    {
        Console.Write(num + " ");
    }
    Console.Write("\n");
    int newLen = 0;
    for (int i = 0; arr.Length > i; i++)
    {
        for (int j = 0; j < arr2.Length; j++)
        {
            if (arr[i] == arr2[j])
                newLen++;
        }
    }
    int[] newarr = new int[newLen];
    int index = 0;
    for (int i = 0; arr.Length > i; i++)
    {
        for (int j = 0; j < arr2.Length; j++)
        {
            if (arr[i] == arr2[j])
            {
                newarr[index] = arr[i];
                index++;
            }

        }
    }
    if (newLen == 0)
    {
        Console.WriteLine("Нет общих элементов");
    }
    else
    {
        Console.WriteLine("Массив общих чисел:");
        foreach (int num in newarr)
        {
            Console.Write(num + " ");
        }
    }
    
}
commonNumbers(randomNumbers2,randomNumbers3);
