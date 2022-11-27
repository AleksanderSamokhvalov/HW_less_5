// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int [] array = new int [200];
GetArray(array);
int [] GetArray(int [] array)
    {
        for (int i = 0; i <array.Length; i++)
            {
            array[i] = new Random().Next(0,100);
            }
        return array;
    }

Console.WriteLine(String.Join(",", array));

int summ_odd = 0;

for (int i = 0; i < array.Length; i++)
    {
        if(i%2!=0)
        {
        summ_odd=summ_odd+array[i];
        }
    }
Console.WriteLine ("Сумма элементов массива с нечетными индексами = " + summ_odd);

