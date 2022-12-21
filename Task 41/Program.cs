// task 41
Console.Clear();
Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];
int count = 0;
Console.WriteLine("Введите числа: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine()); 
    if (array[i] > 0) 
    count++;
 }   
Console.WriteLine("Количество положительных чисел: " + count);