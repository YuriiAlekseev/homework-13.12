// Задача 34: Задайте массив заполненный случайными
//  положительными трёхзначными числами. Напишите программу, 
//  которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int [] CreateMassiv(int count, int begin, int end)
{
    int [] array = new int[count];
    for (int i=0; i<count; i++)
    {
        array[i] = new Random().Next(begin, end+1);
    }
    return array;
}
int EvenNumbers(int [] way)
{
    int count = 0;
    for (int i=0; i < way.Length; i++)
    {
     if(0==way[i]%2)
       {
        count++;
       }      
    }
return count;
}

int [] way = CreateMassiv(4, 100, 999);
Console.Write("[");
Console.Write(String.Join(",", way));
Console.WriteLine("]");
int evennumbers = EvenNumbers(way);
Console.WriteLine($"количество чётных чисел в массиве = {evennumbers}");
