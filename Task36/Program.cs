// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray() 
{     
    int[] array = new int[4];     
    for (int i = 0; i < 4; i++) 
    {         
        array[i] = new Random().Next(-100, 100);     
    }     
    return array; 
} 

int[] array = GetArray(); 
string arrayToStr = String.Join(", ", array); 
Console.WriteLine(arrayToStr); 

void FindSum(int[] array) 
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)     
    {    
        int res = (i % 2);
        if(res != 0) 
        sum += array[i];
    }
    Console.WriteLine("Сумма элементов, стоящих на нечётных позициях равна: " + sum);
}

FindSum(array);