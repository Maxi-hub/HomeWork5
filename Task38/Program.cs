// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] array = new double[] {3.22, 4.2, 1.15, 77.15, 65.2};

double Diff(double[] array) 
{
    double max = array[0];
    double min = array[0];
    double diff = 0;
    for(int i = 0; i < 5; i++)
    {
        if(array[i] > max) max = array[i];
        if(array[i] <= min) min = array[i];
        diff = (max - min);
    }
    
    return diff;
}

Console.WriteLine(String.Join(", ", array));
double dif = Diff(array);
Console.WriteLine("Разница между максимальныи и минимальным элементов массива равна: " + dif);

