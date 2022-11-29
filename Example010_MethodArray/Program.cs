int[] array={1,12,31,4,18,15,16,17,18};
// через точку можно узнать информацию о массиве, в данном случае кол-во элементов
int n=array.Length;
int find=18;
int index=0;

while (index<n)
{
    if(array[index]==find)
    {
    Console.WriteLine(index);
    break;

    }
    // index=index+1;
    index++;
}