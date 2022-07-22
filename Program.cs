// задать массив, заполнеными положительными трехзначными числами.
//показать количество четных чисел
//показать количество нечетных чисел

int[]arr=new int [10];//размер массива
for (int i=0; i<arr.Length; i++)
{
    arr[i]=new Random().Next(99,1000);
    Console.Write($" {arr[i]} "); // задать массив из 10 элементов, заполненных числами из (99,1000)
}
Console.WriteLine();

for (int i=0; i<arr.Length; i++)
{
    if(arr[i]%2==0 )
    {
        Console.Write($" {arr[i]} ");// показали какие числа четные 

    }

}
Console.WriteLine();
for (int i=0; i<arr.Length; i++)
{
    if(arr[i]%2 !=0 )
    {
        Console.Write($" {arr[i]} ");// показали какие числа нечетные 

    }

}

uint even=0;//четные
uint odd=0; // нечетные
for (int i=0; i<arr.Length; i++)
{
    if(arr[i]%2==0 )
    {
       even++; //счетчик четных чисел
    }
else
{
odd++; //счетчик нечетных чисел
}

}
Console.WriteLine();
Console.WriteLine($"колическтво четных  {even}");//показать количество четных чисел
Console.WriteLine($"количество нечетных {odd}");//показать количество нечетных чисел