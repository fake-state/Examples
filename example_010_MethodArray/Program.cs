int[] array = { 1, 21, 3, 41, 15, 6, 17, 81, 19};
int n = array.Length;
int find = 81;
int index = 0;

while (index < n)
{
  if (array[index] == find)
  {
    Console.WriteLine(index);
    break;
  }
index++;
}