Console.WriteLine("Введите длину массива: ");
int num_user = int.Parse(Console.ReadLine());
int [] array = new int[num_user];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
}

Console.WriteLine(string.Join(" ", array));

MultipleNumberArray(array, 4);

void MultipleNumberArray(int[] array, int multy)
{
    int count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] % multy == 0)
        {
            System.Console.Write(array[j] + " ");
            count ++;
        }
    }
    Console.WriteLine("Количество кратное " + multy + " = " + count);
}