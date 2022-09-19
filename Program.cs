/* 
Ex. 56 Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int [,] FillArray(int n, int m)
{
    int[,] array = new int[n, m]; 
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
        }
        Console.WriteLine();
    }
}
int[,] arr = FillArray(5, 3);
PrintArray(arr);
int sum = 0;
int str = 0;
for(int j = 0; j<arr.GetLength(1); j++)
{
int i = 0;
sum = sum+arr[i, j];
str = i;
}
for (int i = 0; i < arr.GetLength(0); i++)
            {
                int temp = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    temp = temp + arr[i, j];
                }
                if (temp < sum)
                {
                    sum = temp;
                    str = i;
                }
            }
            Console.WriteLine("Строка: "+(str+1)+" Сумма - "+sum);
            Console.WriteLine(); */
           
/* 

int temp = 0;
for(int i = 1; i<arr.GetLength(0); i++)
{
    for(int j = 0; j<arr.GetLength(1); j++)
    {
        temp = temp + arr[i, j];
        
    }
    if(temp>sum)
        {
            sum = temp;
            str = i;
        }
}
Console.WriteLine(sum); */



/*
Ex. 54  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int [,] FillArray(int n, int m)
{
    int[,] array = new int[n, m]; 
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
        }
        Console.WriteLine();
    }
}
int[,] arr = FillArray(5, 6);
PrintArray(arr);
int[,] Sorted(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
  return array;
}
int[,] newarr = Sorted(arr);
Console.WriteLine();
PrintArray(newarr); */
/* 
Ex. 58  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int [,] FillArray(int n, int m)
{
    int[,] array = new int[n, m]; 
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] FillNewArray(int[,] arr1, int[,] arr2)
{
    int[,] newarr = new int [arr1.GetLength(0), arr2.GetLength(1)];
  for (int i = 0; i < newarr.GetLength(0); i++)
  {
    for (int j = 0; j < newarr.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < arr1.GetLength(1); k++)
      {
        sum += arr1[i,k] * arr2[k,j];
      }
      newarr[i,j] = sum;
    }
  }
  return newarr;
}
Console.WriteLine("Vvedite chislo strok 1 matric: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Vvedite chislo stolbcov 1 matric: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Vvedite chislo strok 2 matric: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Vvedite chislo stolbcov 2 matric: ");
int y = int.Parse(Console.ReadLine());
if(m != x)
{
Console.WriteLine("Imposible! m=x!");
}
else
{
int[,] arr1 = FillArray(n,m);
int[,] arr2 = FillArray(x,y);
int[,] newarr = FillNewArray(arr1, arr2);
PrintArray(arr1);
Console.WriteLine();
PrintArray(arr2);
Console.WriteLine();
PrintArray(newarr);
} */
/* 
Ex. 60 Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] FillArray(int x, int y, int z)
{
    int[,,] array = new int[x,y,z];
    for(x = 0; x<array.GetLength(0); x++)
    {
        for(y = 0; y<array.GetLength(1); y++)
        {
            for(z = 0; z<array.GetLength(2); z++)
            {
                array[x, y, z] = new Random().Next(0, 10);}
            
            }
    }
    return array;
}
void PrintArray(int[,,] array)
{
    for(int x = 0; x<array.GetLength(0); x++)
    {
        for(int y = 0; y<array.GetLength(1); y++)
        {
            for(int z = 0; z<array.GetLength(2); z++)
            {
                if(array[x, y, z] == array[0, 0, 1] || array[x, y, z] == array[0, 1, 1] || array[x, y, z] == array[1, 0, 1]||array[x, y, z] == array[1, 1, 1])
                {
                continue;
                }
                Console.Write($"{array[x,y,z]} ({x}, {y}, {z}) ");
            }
        }
        Console.WriteLine();
    }
}
int[,,] array = FillArray(2, 2, 2);
PrintArray(array); */
/* 
ex. 62 Напишите программу, которая заполнит спирально массив 4 на 4. 
int n = 4;
int[,] array = new int[n, n];

int p = 1;
int i = 0;
int j = 0;

while (p <= array.GetLength(0) * array.GetLength(1))
{
  array[i, j] = p;
  p++;
  if (i <= j + 1 && i + j < array.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >=array.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > array.GetLength(1) - 1)
    j--;
  else
    i--;
}
void PrintArray(int[,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
PrintArray(array); */