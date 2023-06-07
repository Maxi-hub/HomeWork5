// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int GetLength() 
{     
    Console.WriteLine("Введите длину");     
    int length = Convert.ToInt32(Console.ReadLine());     
    return length; 
} 

int length = GetLength();


int[] GetArray() 
{     
    int[] array = new int[length];     
    for (int i = 0; i < length; i++) 
    {         
        array[i] = new Random().Next(1, 10);     
    }     
    return array; 
} 


void NewArray(int[] array)
{
    int result = 0;
    for(int i = 0; i < length-1; i++)
        {
           result = (array[i] * array[length-1]);
           length = length-1;
           Console.Write(result + " ");
        }
}

int[] array = GetArray(); 
Console.WriteLine(String.Join(", ", array)); 
NewArray(array);