// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины
//"каждая сторона треугольника меньше суммы двух других сторон"
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
int[] array = FillArray(3, 1, 100);
Console.WriteLine('[' + string.Join(", ", array) + ']');

int result =0;
if (array[0] < array[1]+array[2]) 
    {
        if (array[1] < array[0]+array[2])
        {
            if (array[2] < array[0]+array[1]) result = 1;
        }
    }
else result = 0;
if (result == 1) Console.WriteLine("да");
else Console.WriteLine("нет");