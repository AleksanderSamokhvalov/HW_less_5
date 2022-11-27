// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int [] array = new int [5];
GetArray(array);
int [] GetArray(int [] array)
    {
        for (int i = 0; i <array.Length; i++)
            {
            array[i] = new Random().Next(100,1000);
            }
        return array;
    }

Console.WriteLine(String.Join(",", array));

int numder_of_even = 0;

for (int i = 0; i < array.Length; i++)
{
if(array[i]%2==0)
    {
    numder_of_even++;

    }

}
Console.WriteLine ("  Число четных элементов в массиве = " + numder_of_even);