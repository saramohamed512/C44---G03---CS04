using System;

class Ass2
{
    static void Main()
    {
        //#region Question 1

        //Console.Write("Enter an integer:");
        //int num = int.Parse(Console.ReadLine());
        //Console.WriteLine("Print numbers from 1 to n");
        //for (int i = 1; i <= num; i++)
        //{
        //    Console.WriteLine(i);

        //}

        //#endregion

        //#region Question 2

        //Console.Write("Enter an integer:");
        //int num = int.Parse(Console.ReadLine());
        //Console.WriteLine("Multiplication table up to 12");
        //for (int i = 1; i <= 12; i++)
        //{
        //    Console.WriteLine(num * i );
        //}

        //#endregion

        //#region Question 3
        //Console.Write("Enter an integer:");
        //int num = int.Parse(Console.ReadLine());
        //Console.WriteLine("Print even numbers from 1 to n");
        //for (int i = 2; i <= num; i += 2)
        //{
        //    Console.WriteLine(i);
        //}
        //#endregion

        //#region Question 4
        //Console.WriteLine("Calculate power");
        //Console.Write("Enter base: ");
        //int baseNum = int.Parse(Console.ReadLine());
        //Console.Write("Enter exponent: ");
        //int exponent = int.Parse(Console.ReadLine());
        //int result = 1;

        //for (int i = 0; i < exponent; i++)
        //{
        //    result *= baseNum;
        //}

        //Console.WriteLine("Output: " + result );
        //#endregion

        //#region Question 5
        //Console.WriteLine("Calculate total, average and percentage of 5 subjects");
        //Console.Write("Enter Marks of five subjects: ");
        //string[] marks = Console.ReadLine().Split();
        //int total = 0;
        //foreach (string mark in marks)
        //{
        //    total += int.Parse(mark);
        //}
        //int average = total / 5;
        //Console.WriteLine("===============Output================");  

        //Console.WriteLine($"Total marks = {total}");
        //Console.WriteLine($"Average Marks = {average}");
        //Console.WriteLine($"Percentage = {average}");
        //#endregion

        //#region Question 6
        //Console.WriteLine("Reverse a string");
        //Console.Write("Enter a string: ");
        //string strInput = Console.ReadLine();
        //char[] chars = strInput.ToCharArray();
        //Array.Reverse(chars);
        //Console.WriteLine("Output: " + new string(chars) );
        //#endregion

        //#region Question 7
        //Console.WriteLine("Question 7: Reverse an integer");
        //Console.Write("Enter an integer: ");
        //string num = Console.ReadLine();
        //char[] digits = num.ToCharArray();
        //Array.Reverse(digits);
        //Console.WriteLine("Output: " + new string(digits) );
        //#endregion

        //#region Question 8
        //Console.WriteLine("Find prime numbers in a range");
        //Console.Write("Input starting number of range: ");
        //int start = int.Parse(Console.ReadLine());
        //Console.Write("Input ending number of range: ");
        //int end = int.Parse(Console.ReadLine());
        //Console.WriteLine("===============Output================");  
        //for (int i = start; i <= end; i++)
        //{
        //    bool isPrime = true;

        //    if (i <= 1)
        //    {
        //        isPrime = false;
        //    }
        //    else if (i == 2)
        //    {
        //        isPrime = true;
        //    }
        //    else if (i % 2 == 0)
        //    {
        //        isPrime = false;
        //    }
        //    else
        //    {
        //        for (int j = 3; j * j <= i; j += 2)
        //        {
        //            if (i % j == 0)
        //            {
        //                isPrime = false;
        //                break;
        //            }
        //        }
        //    }

        //    if (isPrime)
        //    {
        //        Console.Write(i + " ");
        //    }
        //}

        //#endregion

        //#region Question 9
        //Console.WriteLine("Convert decimal to binary without array");
        //Console.Write("Enter a number to convert: ");
        //int decimalNum = int.Parse(Console.ReadLine());
        //int num= decimalNum; // Store original number for output
        //string binary = "";
        //while (decimalNum > 0)
        //{
        //    binary = (decimalNum % 2) + binary;
        //    decimalNum /= 2;
        //}
        //Console.WriteLine("Output: The Binary of " + num + " is " + binary );
        //#endregion

        //#region Question 10
        //Console.WriteLine("Enter three points (x1 y1 x2 y2 x3 y3):");
        //string[] points = Console.ReadLine().Split();
        //int x1 = int.Parse(points[0]), y1 = int.Parse(points[1]);
        //int x2 = int.Parse(points[2]), y2 = int.Parse(points[3]);
        //int x3 = int.Parse(points[4]), y3 = int.Parse(points[5]);
        //bool colinear = (y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1);
        //Console.WriteLine("Output: " + (colinear ? "The three points lie on a straight line" : "The three points do NOT lie on a straight line") );
        //#endregion

        //#region Question 11
        //Console.WriteLine("Print identity matrix");
        //Console.Write("Enter size n: ");
        //int num = int.Parse(Console.ReadLine());
        //Console.WriteLine("===============Output================");  
        //for (int i = 0; i < num; i++)
        //{
        //    for (int j = 0; j < num; j++)
        //    {
        //        Console.Write(i == j ? "1 " : "0 ");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine();
        //#endregion

        //#region Question 12
        //Console.WriteLine("Sum of array elements");
        //Console.Write("Enter array elements separated by space: ");
        //string[] elements = Console.ReadLine().Split();
        //int sum = 0;
        //foreach (string element in elements)
        //{
        //    sum += int.Parse(element);
        //}
        //Console.WriteLine("Sum = " + sum);
        //#endregion

        //    #region Question 13
        //    Console.WriteLine("Merge and sort two arrays of same size");

        //    // Input array size
        //    Console.Write("Enter size of arrays: ");
        //    int size = int.Parse(Console.ReadLine());

        //    int[] array1 = new int[size];
        //    int[] array2 = new int[size];


        //    Console.WriteLine("\nEnter elements of first array:");
        //    for (int i = 0; i < size; i++)
        //    {
        //        Console.Write($"Element {i + 1}: ");
        //        array1[i] = int.Parse(Console.ReadLine());
        //    }


        //    Console.WriteLine("\nEnter elements of second array:");
        //    for (int i = 0; i < size; i++)
        //    {
        //        Console.Write($"Element {i + 1}: ");
        //        array2[i] = int.Parse(Console.ReadLine());
        //    }

        //    // Sort both arrays
        //    Array.Sort(array1);
        //    Array.Sort(array2);

        //    // Merge the sorted arrays
        //    int[] mergedArray = new int[2 * size];
        //    int i1 = 0, i2 = 0, im = 0;

        //    while (i1 < size && i2 < size)
        //    {
        //        if (array1[i1] < array2[i2])
        //        {
        //            mergedArray[im++] = array1[i1++];
        //        }
        //        else
        //        {
        //            mergedArray[im++] = array2[i2++];
        //        }
        //    }

        //    // Copy remaining elements
        //    while (i1 < size)
        //    {
        //        mergedArray[im++] = array1[i1++];
        //    }

        //    while (i2 < size)
        //    {
        //        mergedArray[im++] = array2[i2++];
        //    }



        //    Console.WriteLine("Merged sorted array:");
        //    Console.WriteLine(string.Join(" ", mergedArray));

        //#endregion

        //#region Question 14
        //Console.WriteLine("Count frequency of each element");
        //Console.Write("Enter array elements (space-separated): ");
        //string[] elements = Console.ReadLine().Split(' ');


        //int[] counts = new int[elements.Length];
        //bool[] counted = new bool[elements.Length];

        //for (int i = 0; i < elements.Length; i++)
        //{
        //    if (!counted[i])
        //    {
        //        counts[i] = 1;
        //        for (int j = i + 1; j < elements.Length; j++)
        //        {
        //            if (elements[i] == elements[j])
        //            {
        //                counts[i]++;
        //                counted[j] = true;
        //            }
        //        }
        //    }
        //}


        //Console.WriteLine("===============Output================");
        //for (int i = 0; i < elements.Length; i++)
        //{
        //    if (!counted[i])
        //    {
        //        Console.WriteLine($"{elements[i]} occurs {counts[i]} times");
        //    }
        //}
        //Console.WriteLine();
        //#endregion

        //#region Question 15
        //Console.WriteLine("Find max and min in array");
        //Console.Write("Enter array elements  (space-separated): ");
        //string[] arrayElements = Console.ReadLine().Split();
        //int max = int.MinValue;
        //int min = int.MaxValue;
        //foreach (string num in arrayElements)
        //{
        //    int val = int.Parse(num);
        //    if (val > max) max = val;
        //    if (val < min) min = val;
        //}
        //Console.WriteLine($"Max = {max}, Min = {min}\n");
        //#endregion

        //#region Question 16
        //Console.WriteLine("Find second largest element");
        //Console.Write("Enter array elements (space-separated): ");
        //string[] arrayElements = Console.ReadLine().Split();
        //int first = int.MinValue, second = int.MinValue;
        //foreach (string num in arrayElements)
        //{
        //    int val = int.Parse(num);
        //    if (val > first)
        //    {
        //        second = first;
        //        first = val;
        //    }
        //    else if (val > second && val != first)
        //    {
        //        second = val;
        //    }
        //}
        //Console.WriteLine("Second largest = " + (second == int.MinValue ? "None" : second.ToString()) );
        //#endregion

        //#region Question 17
        //Console.WriteLine("Longest distance between equal cells");
        //Console.Write("Enter array elements (space-separated):  ");
        //string[] arrayElements = Console.ReadLine().Split();
        //int maxDistance = -1;
        //for (int i = 0; i < arrayElements.Length; i++)
        //{
        //    for (int j = i + 1; j < arrayElements.Length; j++)
        //    {
        //        if (arrayElements[i] == arrayElements[j] && (j - i - 1) > maxDistance)
        //        {
        //            maxDistance = j - i - 1;
        //        }
        //    }
        //}
        //Console.WriteLine("Longest distance = " + (maxDistance == -1 ? "No equal elements" : maxDistance.ToString()) );
        //#endregion

        //#region Question 18
        //Console.WriteLine("Reverse order of words");
        //Console.Write("Input: ");
        //string arrayElements = Console.ReadLine();
        //string[] words = arrayElements.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        //Array.Reverse(words);
        //Console.WriteLine("===============Output================");
        //Console.WriteLine(string.Join(" ", words) );
        //#endregion

        //#region Question 19
        //Console.WriteLine("Copy multidimensional array");
        //Console.Write("Enter number of rows: ");
        //int rows = int.Parse(Console.ReadLine());
        //Console.Write("Enter number of columns: ");
        //int cols = int.Parse(Console.ReadLine());
        //int[,] array1 = new int[rows, cols];
        //int[,] array2 = new int[rows, cols];
        //Console.WriteLine("Enter elements row by row:");
        //for (int i = 0; i < rows; i++)
        //{
        //    string[] row = Console.ReadLine().Split();
        //    for (int j = 0; j < cols; j++)
        //    {
        //        array1[i, j] = int.Parse(row[j]);
        //        array2[i, j] = array1[i, j];
        //    }
        //}
        //Console.WriteLine("===============Output================");
        //for (int i = 0; i < rows; i++)
        //{
        //    for (int j = 0; j < cols; j++)
        //    {
        //        Console.Write(array2[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine();
        //#endregion

        //#region Question 20
        //Console.WriteLine("Print array in reverse order");
        //Console.Write("Enter array elements: ");
        //string[] arrayElements = Console.ReadLine().Split();
        //Console.Write("Output: ");
        //for (int i = arrayElements.Length - 1; i >= 0; i--)
        //{
        //    Console.Write(arrayElements[i] + " ");
        //}
        //Console.WriteLine();
        //#endregion
    


}
}