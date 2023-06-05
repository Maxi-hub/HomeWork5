// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GetArray() 
{     
    int[] array = new int[5];     
    for (int i = 0; i < 5; i++) 
    {         
        array[i] = new Random().Next(1, 10);     
    }     
    return array; 
} 

int[] array = GetArray(); 

int[] NewArray(int[] array)
{
    int[] result = new int[array];
    for(int i = 0; i < result.Length; i++)
        {
        result[i] = (result[i] * result[result.Length - 1]);
        }
    return result;
}

int[] newarray = NewArray();
Console.WriteLine(String.Join(", ", newarray)); 
