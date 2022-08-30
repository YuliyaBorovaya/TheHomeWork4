//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]


int[] array1 = {1, 2, 5, 7, 19};
int[] array2 = {6, 1, 33};

int[] result = new int[array1.Length + array2.Length];
array1.CopyTo(result, 0);
array2.CopyTo(result, array1.Length);
 
Console.WriteLine(String.Join(", ", result));    
    


