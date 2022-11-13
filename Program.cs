//                              ДОМАШНЕЕ ЗАДАНИЕ

// // ЗАДАЧА 25: Напишите программу, которая принимает на вход два числа (А и В) 
// //            и возвращает число А в натуральную степень В (Math.Pow НЕ использовать)

// int CokingDegree(int A, int B)
// {
//     int result = 1;
//     for(int i = 0; i < B; i++)
//     {
//         result *= A;
//     }
//     return result;
//     //Console.WriteLine($"The result of raising number {A} to the power of {B} is {result}");// для void
// }

// Console.WriteLine("Enter the number to be raised: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the degree to raise: ");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"The result of raising number {A} to the power of {B} is {CokingDegree(A, B)}");
// //CokingDegree(A, B); // для void

// // ЗАДАЧА 27: Напишите программу, которая принимает на вход число
// //            и выдает сумму цифр в числе

// void SumDigit( int number)
// {
//     int result = 0;
//     int temp = 0;
//     while(1 <= number)
//     {
//         temp = number % 10;
//         result = result + temp;
//         number = number / 10;
//     }
//     Console.WriteLine($"The sum of the digits of the number {number} is {result}");
// }

// Console.WriteLine("Enter any integer: ");
// double check = Convert.ToDouble(Console.ReadLine());

// if(check % 1 == 0) 
// {
//     int number = Convert.ToInt32(check);
//     if(number < 0) number = number * -1;
//     SumDigit(number);
// }
// else Console.WriteLine($"Еhe entered number {check} is not an integer");

// //ЗАДАЧА 29: Напишите программу, которая создает массив заданного пользователем размера,
// //           заполняет массив элементами от 1 до 99 и выводит на экран

// int [] CreatRandArray(int N)
// {
//     int [] arr = new int[N];
//     for(int i = 0; i < N; i++)
//     {
//         arr[i] = new Random().Next(1, 100);
//     }
//     return arr;
// }

// void PrintArray(int [] arr)
// {
//     Console.Write("[");
//     for(int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + ", ");
//     }
//     Console.WriteLine("\b\b]");
// }

// Console.WriteLine("Specify the size of the array to be created: ");
// int N = Convert.ToInt32(Console.ReadLine());
// PrintArray(CreatRandArray(N));














// // ЗАДАЧА 1. Напишите программу, которая принимает на вход число (А) 
// //           и выдает сумму чисел от 1 до А

// int Summa(int A)
// {
//     int sum = 0;
//     for(int i = 1; i <= A; i++)
//     {
//        sum += i; //sum = sum + i;
//     }
//     return sum;
// }

// Console.WriteLine("Enter a positive integer: ");
// //int A = Convert.ToInt32(Console.ReadLine());
// //Console.WriteLine($"The sum of the numbers from 1 to {A} is {Summa(A)}");
// //Console.Write("Enter any integer greater than zero: ");
// double check = Convert.ToDouble(Console.ReadLine());
// int A = 0;
// if(check % 1 == 0) 
// {
//     A = Convert.ToInt32(check);
//     if(A > 0) Console.WriteLine($"The sum of the numbers from 1 to {A} is {Summa(A)}");
//     else Console.WriteLine($"The entered number {A} is not greater than zero"); 
// }
// else Console.WriteLine($"The entered number {A} is not an integer");

// ЗАДАЧА 2. Напишите программу, которая находит в последовательности от 1 до N 
//           все нечетные числа

/*void CheckOdd(int num)
{
    // for(int i = 1; i <= num; i++)
    // {
    //     if(i % 2 == 0);
    //     else Console.WriteLine($"{i}");
    // }
    for(int i = 1; i <= num; i = i + 2)
    {
        Console.Write($"{i}, ");
    }
}

Console.WriteLine("Enter any positive integer number: ");
double check = Convert.ToDouble(Console.ReadLine());
int num = 0;
if(check % 1 == 0)
{
    num = Convert.ToInt32(check);
    if(num > 0) CheckOdd(num);
    else Console.WriteLine($"The entered number {num} is not greated than zero");
    Console.WriteLine();
} 
else Console.WriteLine($"The entered number {num} is not an integer");
*/

/*// ЗАДАЧА 3. Напишите программу, которая принимает на вход число N 
//           и выдает произведение чисел от 1 до N

int Multiplication(int N)
{
    int result = 1;
    for(int i = 1; i <= N; i++)
    {
        result *= i; //result = result * i;
    }
    return result;
}

Console.WriteLine($"Enter any positive integer: ");
double check = Convert.ToDouble(Console.ReadLine());
int N = 0;
if(check % 1 == 0)
{
    N = Convert.ToInt32(check);
    if(N >= 0) Console.WriteLine($"The factorial of the number {N} is {Multiplication(N)}");
    else Console.WriteLine($"The entered number {N} is not positive");
}
else Console.WriteLine($"The entered number {N} is not an integer");
*/

/*//ЗАДАЧА 4. Напишите программу, которая принимает на вход число 
//          и выдает количество цифр в числе

void NumberLength(int number)
{
    //string text = Convert.ToString(number);
    //int length = text.Length;
    //Console.WriteLine($"The number of digits in the number {number} is {length}");
    
    // int count = 0;
    // if(number < 1) Console.WriteLine($"The number of digits in the number {number} is 1"); // если число равно 0
    // else 
    // {
    //   for(int i = 1; i <= number; i *= 10)
    //    {
    //         count++;
    //    }
    // Console.WriteLine($"The numbeu of digits in the number {number} is {count}");
    // }

    int count = 0;
    while(number > 0 )
    {
        count++;
        number = number / 10;
    }
    Console.WriteLine($"The number of digits in the number {number} is {count}");
}

Console.WriteLine("Enter any positive integer: ");

double check = Convert.ToDouble(Console.ReadLine());
int number = 0;
if(check % 1 == 0)
{
    number = Convert.ToInt32(check);
    if(number >= 0)
    {
        NumberLength(number);
    }
    else Console.WriteLine($"The entered number {number} is not positive");
}
else Console.WriteLine($"The entered number {number} is not an integer");
*/

//ЗАДАЧА 5. Напишите программу, которая выводит массив из 8 элементов,
//          заполненный нулями и единицами в случайном порядке [1, 0, 1, 1, 0, 1, 0, 0]


// void FullArray(int [] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 2);
//        // Console.Write(array[i] + " ");
//     }
//     //Console.WriteLine();
// }

// void PrintArray(int [] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int [] array = new int[8];
// FullArray(array);
// PrintArray(array);

/*int [] CreatRandArray (int n, int minVal, int maxVal)
{
    int [] arr = new int[n];
    for(int i = 0; i < n ; i++)
    {
        arr[i] = new Random().Next(minVal, maxVal+1);
    }
    return arr;
}

void PrintArray(int [] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine("\b\b]");
    Console.WriteLine();
}

PrintArray(CreatRandArray(8, 0, 1));
*/
