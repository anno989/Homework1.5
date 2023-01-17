//****ДОМАШНЕЕ ЗАДАНИЕ*****

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

// int[] array = GetArray(10, 100, 999);
// Console.WriteLine($"[{String.Join(",", array)}]");
// Console.WriteLine($"количество чётных чисел в массиве равно {CountElement(array)}");

// int CountElement(int[] array)
// {   
//     int count = 0;
//     foreach(int el in array)
//     {
//         if(el % 2 == 0)
//         {
//             count++;
//         }
//     } 
//     return count;
// }


// //Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] array = GetArray(5, 10, 100);
// Console.WriteLine($"[{String.Join(",", array)}]");
// Console.WriteLine($"сумма элементов с нечётными индексами равна {OddIndexSumElement(array)}");

// int OddIndexSumElement(int[] array)
// {   
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(i % 2 != 0)
//             {
//                 sum += array[i];
//             }  
//     } 
//     return sum;
// }


//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.

int[] array = GetArray(8, 5, 10);
int[] MultArray = MultiplyArray(array); 
Console.Write($"Произведение пар чисел в массиве  ");
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine($"[{String.Join(",", MultArray)}]");

int[] MultiplyArray(int[] array) //входные параметры метода[
{
    int arrayMultLength = 0;
    if(array.Length % 2 == 0)
    {
      arrayMultLength = array.Length / 2;  
    }
    else
    {
       arrayMultLength = array.Length / 2 + 1;
    }
   
   
    int[] MultArray = new int[arrayMultLength];
    int currentMult = 0;
    for(int i = 0; i < array.Length / 2; i++)
    {
        currentMult = array[i] * array[array.Length-1-i];
        MultArray[i] = currentMult;
    }
    if(array.Length % 2 != 0)
    {
        MultArray[MultArray.Length-1] = array[array.Length / 2];
    }
    return MultArray;
}


//-----Основной метод (для всех задач)-------------
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
