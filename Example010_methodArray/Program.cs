int[] array = {11, 12, 13, 14, 15, 16, 17, 18, 19, 13};

int n = array.Length;
int find = 13;

int index = 0;

while (index < n)
{
    if (array [index] == find)
    {
    Console.WriteLine(index);
    }
    index = index + 1;
}