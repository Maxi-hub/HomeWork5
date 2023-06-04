// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] GetArray() 
{     
    int[] array = new int[123];   
    for (int i = 0; i < 123; i++) 
    {         
        array[i] = new Random().Next(0, 124);     
    }     
    return array; 
} 

int[] array = GetArray(); 
string arrayToStr = String.Join(", ", array); 
Console.WriteLine(arrayToStr);

void Res(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 10 && array[i] <= 99)
        count++;
    }
    Console.WriteLine("Количество элементов массива, значения которых лежат в отрезке [10,99] : " + count);
}

Res(array);
