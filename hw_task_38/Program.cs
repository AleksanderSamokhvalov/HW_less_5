// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

// [3 7 22 2 78] -> 76

double [] array = new double [11];
GetArray(array);
double [] GetArray(double [] array)
    {
        for (int i = 0; i <array.Length; i++)
            {
            array[i] = new Random().Next(-999,1000);
            }
        return array;
    }

Console.WriteLine(String.Join(" // ", array));

double max_number = array[0];
double min_number = array[0];

for (int i = 0; i < array.Length; i++)
{
    if(array[i]>max_number)
    {  
        max_number=array[i];
    }
     if (array[i]<min_number)
    {
        min_number=array[i];
    }
}
Console.WriteLine("Максимальное число массива = " + max_number);
Console.WriteLine("Минимальное число массива = " + min_number);

double result = (max_number - min_number);

Console.WriteLine("Разница между максимальным и минимальным числом масссва = " + result);