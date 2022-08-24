// Напишите программу, которая перевернет одномерный массив (последний элемент на первом месте, а первый на последнем)
const int ARRAY_SIZE = 9; // размер массива
const int LEFTRANGE = -10; // нижняя граница рандома
const int RIGHTRANGE = 10; // верхняя граница рандома

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

void ReverseArray(int[] arr)              //можно было бы использовать не void  но тогда пришлось бы создавать еще один массив чтобы записывать новый массив Reverse
{
    int temp = 0; //используем доп.переменную temp, равную первому элементу массива
    for (int i = 0; i < arr.Length/2; i++) // так как нечетное кол-во элементов, то arr.length/2  
    {   /* допусим у нас массив [3, -9, -3, 7, 10 ]    */ 
        temp = arr[i];                   // сюда записали первый элемент (в temp  сначала записали 3)
        arr[i] = arr[arr.Length - 1 -i]; // записываем в течении цикла в первый элемент последний (далее arr[i] принимает значение [10, -9, -3, 7, 10])  
        arr[arr.Length - 1 -i] = temp;   // последний элемент будет равен temp (то есть 3)
    }
}
// int[] array = FillArray(5, -10, 10); вместо элементов указали константы
int[] array = FillArray(ARRAY_SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine('[' + string.Join(", ", array) + ']');
ReverseArray(array);
Console.WriteLine('[' + string.Join(", ", array) + ']');