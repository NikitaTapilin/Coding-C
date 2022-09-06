int[] array = {10, 32, 13, 18, 35, 61, 27, 18};

int n = array.Length;
int find = 18;

int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index ++;
}