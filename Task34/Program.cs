// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел
//  в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray() 
{     
    int[] array = new int[5];     
    for (int i = 0; i < 5; i++) 
    {         
        array[i] = new Random().Next(100, 1000);     
    }     
    return array; 
} 

int[] array = GetArray(); 

string arrayToStr = String.Join(", ", array); 
Console.WriteLine(arrayToStr); 


void SearchNumber(int[] array) 
{    
    
    int count = 0; 
    for (int i = 0; i < array.Length; i++)     
    {     
        int result = (array[i] % 2);
        if(result == 0)
        count++;
    }
    Console.WriteLine("Количество четных чисел в массиве: " + count);
}
SearchNumber(array);

