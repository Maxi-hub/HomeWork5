// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


// double[] array = new double[] {3.22, 4.2, 1.15, 77.15, 65.2};  // ручной ввод чисел или рандомный ниже

double[] arr = new double[5];
Random random = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.NextDouble() * 10;
    Console.WriteLine(Math.Round(arr[i], 2));
}

void Diff(double[] array)
{
    double max = array[0];
    double min = array[0];
    double diff = 0;
    for (int i = 0; i < 5; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] <= min) min = array[i];
        diff = (max - min);
    }
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна: " + Math.Round(diff, 2));
}

Diff(arr);


