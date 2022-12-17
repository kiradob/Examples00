
void FillArray(int[] collection)
{
    int length=collection.Length;
    int index=0;
    while (index<length)
    {
        collection[index]=new Random().Next(1,10);
        // index=index+1;
        index++;
    }
}
// Печать массива
void PrintArray(int[] col)
{
    int count=col.Length;
    int position=0;
    while (position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
// Возвратный метод IndexOf
int IndexOf(int[] collection, int find)
{
    int count=collection.Length;
    int index=0;
// Если элемента нет, по возвращаем -1
    int position=-1;
    while (index<count)
    {
        if(collection[index]==find)
        {
// Находим первое вхождение и прерываем break
            position=index;
            break;
        } 
        index++;
    }
    return position;
}
// Определили массив из 10 элементов
int[] array=new int[10];

// Вызвали метод FillArray, который заполнил массив рандомными числами от 1 до 10
FillArray(array);
array[4]=4;
array[6]=4;
// Вызвали метод PrintArray, который распечатал массив
PrintArray(array);
Console.WriteLine();
int pos=IndexOf(array,9);
Console.WriteLine(pos);