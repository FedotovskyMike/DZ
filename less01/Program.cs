/* Задача 34: Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.
[345, 897, 568, 234] -> 2 */

/* Задача 36: Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

/* Задача 38: Задайте массив вещественных чисел. Найдите
разницу между максимальным и минимальным
элементов массива. */


int sum = 0;
int index = 1;
int even = 0;
void Print(int[] arr)

{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int[] mass = new int[4];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(100, 1000);
}

foreach (int i in mass)
{
    if (i % 2 == 0) even++;
    
    if (index % 2 == 0) sum += i;
    
    index++;
    
}
Console.WriteLine(mass.Max() - mass.Min());
Console.WriteLine(sum);
Console.WriteLine(even);
Print(mass);





