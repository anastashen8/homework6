// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void Print(int[] arrey)
{    
    for (int i = 0; i < arrey.Length; i++) 
    {
        Console.Write(arrey[i] + ",");
    }
}
int [] array = {1, 2, 5, 7, 19};
Print (array);
Console.WriteLine();
int [] array2 = {6, 1, 33};
Print (array2);