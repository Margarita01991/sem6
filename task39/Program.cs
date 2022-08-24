// Напишите программу, которая перевернет одномерный массив (последний элемент на первом месте, а первый на последнем)
const int ARRAY_SIZE = 5; // размер массива
const int LEFTRANGE = -10; // первый элемент
const int RIGHTRANGE = 10; // последний элемент

int[] FillArray (int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int [size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

void ReverseArray(int [] arr)
{
    int temp = 0; //используем доп.переменную temp, равную первому элементу массива
    for (int i = 0; i < arr.Length/2; i++) // так как нечетное кол-во элементов, то arr.length/2
    {
        temp = arr[i];                   // сюда записали первый элемент
        arr[i] = arr[arr.Length - 1 -i]; // записываем в течении цикла в первый элемент последний
        arr[arr.Length - 1 -i] = temp;   // последний элемент будет равен temp
    }
}

// int[] array = FillArray(5, -10, 10); вместо элементов указали константы
int[] array = FillArray(ARRAY_SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine('[' + string.Join(", ", array) + ']');
ReverseArray(array);
Console.WriteLine('[' + string.Join(", ", array) + ']');