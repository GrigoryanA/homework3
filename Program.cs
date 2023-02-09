//Task 2

double LineLength(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double line1Length = x2 - x1;
    double line2Length = y2 - y1;
    double line3Length = z2 - z1;
    double result = Math.Sqrt(Math.Pow(line1Length, 2) + Math.Pow(line2Length, 2) + Math.Pow(line3Length, 2));
    return result;
}

Console.Write("Введите координату Х первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Х второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z второй точки: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Длина отрезка: " + Math.Round(LineLength(x1,y1,z1,x2,y2,z2), 2));

//Task 3
/* bool IsPalindrome(int number)
{
    int number1 = number, number2 = 0;
    while(number1 > 0)
    {
        number2 = number2 * 10 + number1 % 10;
        number1 /= 10;
    }
    return number2 == number;
}

Console.Write("Enter N: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {num} " + (IsPalindrome(num) ? "": "не ") + "является палиндромом.");
*/



/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125  */

int number = ReadInt("Введите число: ");

for (int i = 1; i <= number; i++)
{
    Console.Write($"{i * i * i}, ");
}

// Метод
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetSum(int num)
{
    int sum = 0;

     for(int current=1;current <= num current++);
     {
        sum += current;
      
    }
   return sum; 

   int a;
}
   do
   {

Console.Write("input a positive number:");
a = Convert.ToInt32(Console.ReadLine());


   }
   while(a < 0);
   int a = Convert.ToInt32(Console.ReadLine());

   int result = GetSum(a);
   Console WriteLine($"Sum of elements form 1 to {a} is {result}");

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i ++ )
    array[i] = new Random().Next(minValue, maxValue + 1);

    return array;

}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i ++)
    Console.Write(array[i]+ "");

    Console.WriteLine();

}
Console.Write("Input a length of new array:");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value:");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length,min,max);
ShowArray(myArray);



/* Задача 25:
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵);   2, 4 -> 16   */
int numberA = ReadInt("Введите число:");
int numberB = ReadInt("ВВедите степень:");
ToDegree(numberA, numberB);

// Функция возведение в степень void
void ToDegree(int a, int b)
{

{int result = 1;for (int i = 1; i <= b; i ++) {result = result * a;}

Console.WriteLine(a+ "в степени" + b +"=" result);}

// Функция ввода int Readint(string message)
{Console.WriteLine(Messsage);

return
Convert.ToInt32(Console ReadLine()); }

}

/* Задача 27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11;  82 -> 10;  9012 -> 12   */

int number = ReadInt ("Введите число:");

int len = NumberLen(number);
SumNumbers(number,len);

//Функция подсчета цифр в числе int
NumberLen(int a) {int index = 0; while (a>0) {a/=10; index ++;} return index;}

//Функция вывода суммы цифр в числе 

void SumNumbers(int n, int len){int = 0;for(int i = 1; i <= len i ++) {SumNumbers += n % 10; n/=10;} 
Console WriteLine ($"сумма цифр {Sum}");}

//Функция ввода 

int Readint(string message ){Console.Write(message);

return Convert.ToInt32(Console.ReadLine());}


/* Задача 29 Напишите программу, которая задаёт массив из N элементов и выводит их на экран. 5 -> [1, 2, 5, 7, 19]; 3 -> [6, 1, 33] */


int lenArray =Readint("Введите длину массива:");

int[] randomArray = new int[lenArray];

for (int i = 0; i < randomArray.Length; i ++)
{randomArray[i] = new Random().Next(1, 9);
Console.Write(randomArray[i] +"");}

//Функция ввода 

int Readint(string message){Console.Write(message);
return 
Convert.ToInt32(Console.ReadLine()); } 
 


 
  
int GetSum(int num)
{

int sum = 0;

  for(int current = 1; current <= num; current ++)
{
    sum += current;
}
}

int current = 1;
while(current <= num)
{
    sum += current; 
    current ++;




 return sum;



 int a;
}
 do 
{
    Console.Write("input a positive number:");
    a = Convert.ToInt32(Console.ReadLine());
}
while(a < 0);

Console.Write("Input a positive number: ");
int a = Convert.ToInt32(Console.ReadLine());


int resulte = GetSum(a);
Console.WriteLine($"Sum of elements form 1 to {a} is {result}");

