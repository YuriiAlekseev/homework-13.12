// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int [] CreateMassiv(int count, int begin, int end)
{
    int [] array = new int[count];
    for (int i=0; i<count; i++)
    {
        array[i] = new Random().Next(begin, end+1);
    }
    return array;
}
int Difference(int [] way)
{
    int dif = 0;
    int min = way.Max();
    int max = way.Min();
    for (int i=0; i < way.Length; i++)
    {
     if(way[i]>max)
       {
        max = way[i];
       }  
    if(way[i]<min)
       {
        min = way[i];
       }   
          
    }
    dif = max - min;
return dif;
}

int [] way = CreateMassiv(5, 0, 100);
Console.Write("[");
Console.Write(String.Join(",", way));
Console.WriteLine("]");
int difference = Difference(way);
Console.WriteLine($"разницу между максимальным и минимальным элементов массива = {difference}");
