// ********************************************************
// Находим максимальное число и вывводим index и останавливаем программу


int[] array = { 81, 28, 30, 256, 94, 55, 56, 47, 256};

int n = array.Length;
int find = 256;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        System.Console.WriteLine(index);
        break; 
    }
    index++;
}