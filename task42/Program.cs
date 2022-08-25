// Программа, которая будет преобразовывать десятичное число в двоичное
/* STRING
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()); 
string result = String.Empty;
while (n !=0)
{
    result+=Convert.ToString(n % 2);
    n = n / 2;
}
Console.Write(result);
*/

/* FOR
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()); 
// int d = 0;

for (int i = 0; n >= 1; i++) // FOR (инициализация счетчика I; проверка условия I<COUNT; инкремент i++)
{
    d = n % 2;
    n = n / 2;
    Console.Write(d);
}
*/
/* РЕКУРСИЯ*/
void PrintBinary(int N)                                          // вызываем метод, передаем наше число n == 45                                         
{                                                                // 
    if (N <= 0) return;// при каком условии точка остановки      
    PrintBinary(N / 2);                                          // пока условие N>=0 выполняется, метод зациклен, выполняется 7 заходов. Как только N < 0, функция останавливается идет обратный reverse 
    Console.Write(N % 2);                                        // и записывается остаток от деления в обратном порядке
}

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintBinary(n); //вызываем метод