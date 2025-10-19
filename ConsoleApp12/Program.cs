//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 3, 8, 5, 12, 7, 9 };

//        int[] newArray = new int[numbers.Length];
//        int start = 0;                
//        int end = numbers.Length - 1; 

//        foreach (int num in numbers)
//        {
//            if (num % 2 == 0) 
//            {
//                newArray[start] = num;
//                start++;
//            }
//            else 
//            {
//                newArray[end] = num;
//                end--;
//            }
//        }

//        Console.WriteLine("Yeni array:");
//        foreach (int n in newArray)
//        {
//            Console.Write(n + " ");
//        }
//    }
//}
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] nums = { 4, 15, 2, 9, 11, 7 };

//        int min = nums[0];
//        int max = nums[0];

//        foreach (int num in nums)
//        {
//            if (num < min)
//            {
//                min = num;
//            }

//            if (num > max)
//            {
//                max = num;
//            }
//        }

//        int ferq = max - min;

//        Console.WriteLine("En kiçik: " + min);
//        Console.WriteLine("En böyük: " + max);
//        Console.WriteLine("FErq: " + ferq);
//    }
//}
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] arr = { 10, 20, 30, 40, 50 };


//        for (int i = 0; i < arr.Length / 2; i++)
//        {
//            int temp = arr[i];
//            arr[i] = arr[arr.Length - 1 - i];
//            arr[arr.Length - 1 - i] = temp;
//        }


//        foreach (int item in arr)
//        {
//            Console.Write(item + " ");
//        }
//    }
//}
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] arr = { 5, 10, 15, 20, 25 };

//        int sum = 0;

//        foreach (int num in arr)
//        {
//            sum += num;
//        }


//        double average = (double)sum / arr.Length;
//        Console.WriteLine("Ortalama: " + average);


//        Console.WriteLine("Ortalamadan böyük ədədlər:");
//        foreach (int num in arr)
//        {
//            if (num > average)
//            {
//                Console.WriteLine(num);
//            }
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 2, 3, 7, 8, 10, 11, 15 };

//        int tekSay = 0;
//        int cutSay = 0;


//        foreach (int num in numbers)
//        {
//            if (num % 2 == 0)
//                cutSay++;
//            else
//                tekSay++;
//        }


//        if (tekSay > cutSay)
//            Console.WriteLine("Tək ədədlər çoxdur");
//        else
//            Console.WriteLine("Cüt ədədlər çoxdur");
//    }
//}
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] arr1 = { 1, 5, 9, 12, 7, 3 };
//        int[] arr2 = { 4, 9, 12, 8, 3, 10 };

//        Console.WriteLine("Ortaq ədədlər:");

//        foreach (int num1 in arr1)
//        {
//            foreach (int num2 in arr2)
//            {
//                if (num1 == num2)
//                {
//                    Console.WriteLine(num1);
//                    break; 
//                }
//            }
//        }
//    }
//}
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] nums = { 8, 3, 12, 7, 4, 10 };

//        for (int i = 0; i < nums.Length - 1; i++)
//        {
//            for (int j = i + 1; j < nums.Length; j++)
//            {
//                if (nums[j] < nums[i])
//                {
                   
//                    int temp = nums[i];
//                    nums[i] = nums[j];
//                    nums[j] = temp;
//                }
//            }
//        }

//        Console.WriteLine("Artan sıra ilə düzülmüş array:");
//        foreach (int n in nums)
//        {
//            Console.Write(n + " ");
//        }
//    }
//}

