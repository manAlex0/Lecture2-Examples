void FillArray(int[] collection) //Метод заполнения массива
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) //Метод печати на экран
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) //Метод нихождения индекса
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; //создаем массив из 10ти эллементов

FillArray(array);
array[4] = 4;
array[7] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 44);
System.Console.WriteLine(pos);
