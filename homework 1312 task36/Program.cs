// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] CreateMassiv(int count, int begin, int end)
{
    int [] array = new int[count];
    for (int i=0; i<count; i++)
    {
        array[i] = new Random().Next(begin, end+1);
    }
    return array;
}
int OddPositions(int [] way)
{
    int sum = 0;
    for (int i=0; i < way.Length; i++)
    {
     if(0 != way[i]%2)
       {
        sum = sum + way[i];
       }      
    }
return sum;
}

int [] way = CreateMassiv(5, 0, 100);
Console.Write("[");
Console.Write(String.Join(",", way));
Console.WriteLine("]");
int oddpositions = OddPositions(way);
Console.WriteLine($"сумму элементов, стоящих на нечётных позициях = {oddpositions}");
