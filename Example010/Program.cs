int[] array = { 1, 2, 3, 4, 5, 76, 87, 45 };

int n = array.Length;
int find = 1;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
