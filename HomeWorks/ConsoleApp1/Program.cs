using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK 1
            //int temp = int.Parse(Console.ReadLine());
            //if (temp <= 15)
            //{
            //    Console.WriteLine("Hava Soyuqdur");
            //}
            //else
            //{
            //    Console.WriteLine("Hava Istidir");
            //}
            //TASK 2
            //string month = "Dekabr";
            //switch (month)
            //{
            //    case  "Yanvar":
            //    case "Mart":
            //    case "May":
            //    case "Iyul":
            //    case "Avqust":
            //    case "Oktyabr":
            //    case "Dekabr":
            //        Console.WriteLine("31");
            //        break;
            //    case "Fevral":
            //        Console.WriteLine("28 ve ya 29");
            //        break;
            //    case "Aprel":
            //    case "Iyun":
            //    case "Sentyabr":
            //    case "Noyabr":
            //        Console.WriteLine("30");
            //        break;
            //    default:
            //        Console.WriteLine("Bele ay yoxdur");
            //        break;  
            //}
            //TASK 3
            //int num = int.Parse(Console.ReadLine());
            //int factorial = 1;
            //for (int i = 1; i <= num; i++)
            //{
            //    factorial*= i;
            //}
            //Console.WriteLine(factorial);
            //TASK 4
            //int num = int.Parse(Console.ReadLine());
            //int count = 0;
            //for (int i = 2; i < num; i++)
            //{
            //    if (num%1==0)
            //    {
            //        count++;
            //        if (count == 1)
            //        {
            //            Console.WriteLine("Eded Murekkebdir");
            //            break;
            //        }
            //    }
            //    Console.WriteLine("Eded Sadedir");
            //    break;
            //}
            //TASK 5
            //int[] nums = {1, 2, 4, 5, 6, 8, };
            //int sum = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i]%2!=0)
            //    {
            //        sum += nums[i];
            //    }
            //}
            //Console.WriteLine(sum);
            //TASK 6
            //int[] nums = { 5, 11, -5723, 13, 421, 87, 5724, 505 };
            //int min = nums[0];
            //int max = nums[0];
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (min > nums[i])
            //    {
            //        min = nums[i];
            //    }
            //    if (max < nums[i])
            //    {
            //        max = nums[i];
            //    }
            //}
            //Console.WriteLine("En kicik eded " + min);
            //Console.WriteLine("En boyuk eded " + max);
            //Console.WriteLine("Cemi:" + (min + max));
            //TASK 7
            //int num = int.Parse(Console.ReadLine());
            //int a = num % 10;
            //int b = num / 10;
            //b = num % 10;
            //int c = num % 10;
            //if (a==b && b ==c && a==c)
            //{
            //    Console.WriteLine("Beraberdir");
            //}
            //else
            //{
            //    Console.WriteLine("Beraber deyil");
            //}
            //TASK 9
            //int[] arr = { 2, 8, 14, 16, 19, 21 ,35};
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i]%2!=0)
            //    {
            //        sum += arr[i];
            //        Console.WriteLine(sum);
            //    }              
            //}
            //TASK 10 
            //int[] nums = { 5, 11, -5723, 13, 421, 87, 5724, 505 };
            //int min = nums[0];
            //int max = nums[0];
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (min > nums[i])
            //    {
            //        min = nums[i];
            //    }
            //    if (max < nums[i])
            //    {
            //        max = nums[i];
            //    }
            //}
            //Console.WriteLine("En kicik eded " + min);
            //Console.WriteLine("En boyuk eded " + max);
            //Console.WriteLine("Cemi:" + (min + max));
            //TASK 11
            //int[] nums = { 5, 11, -5723, 13, 421, 87, 5724, 505 };
            //int count = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    count++;
            //}
            //Console.WriteLine(count);
            //TASK 12
            //int num = int.Parse(Console.ReadLine());
            //int a = num % 10;
            //int b = num / 10;   
            //if (a>b)
            //{
            //    Console.WriteLine("Onluq Boyukdur");
            //}
            //else if (a==b)
            //{
            //    Console.WriteLine("Beraberdir");
            //}
            //else
            //{
            //    Console.WriteLine("Teklik Boyukdur");
            //}
            //TASK 13
            //int[] arr = { 1, 2, 4, 8, 14, 15, 16, 17, 18, };
            //int max = 0;
            //int min = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[max] < arr[i])
            //    {
            //        max = i;
            //    }
            //    if (arr[min] > arr[i])
            //    {
            //        min = i;
            //    }

            //}
            //arr[max] += arr[min];
            //arr[min] = arr[max] - arr[min];
            //arr[max] = arr[max] - arr[min];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //TASK 14
            //int num = int.Parse(Console.ReadLine());
            //int count = 0;
            //while (num > 0)
            //{
            //    num /= 10;
            //    count++;
            //}
            //Console.WriteLine("Eded " + count + " mertebelidir");
            //TASK 15
            //int num = int.Parse(Console.ReadLine());
            //int a = num * 10 +8;
            //Console.WriteLine(700000+a);
            //TASK 16
            //int num = int.Parse(Console.ReadLine());
            //int a = num * 1000;
            //Console.WriteLine(a+num);
            //TASK 17
            //int num = int.Parse(Console.ReadLine());
            //int a = num * 10+7;
            //Console.WriteLine((a*7)/100);
            //TASK 18
            //int num = int.Parse(Console.ReadLine());
            //if (num%2 == 0)
            //{
            //    Console.WriteLine("Eded Cutdur");
            //}
            //else
            //{
            //    Console.WriteLine("Eded Tekdir");
            //}
            //TASK 19
            //int num = int.Parse(Console.ReadLine());
            //if (num%21==0)
            //{
            //    Console.WriteLine("Bolunur");
            //}
            //else
            //{
            //    Console.WriteLine("Bolunmur");
            //}
            //TASK 20
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //if (num1>num2)
            //{
            //    Console.WriteLine("Birinci eded boyukdur");
            //}
            //else if (num1==num2)
            //{
            //    Console.WriteLine("Beraberdir");
            //}
            //else
            //{
            //    Console.WriteLine("Ikinci eded boyukdur");
            //}
            //TASK 21
            //string[] arr = { "AB106", "AB111", "AB777", "AB1006" };
            //bool result = false;
            //int i = 0;
            //for (i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == "AB106")
            //    {
            //        result = true;
            //        break;
            //    }
            //}
            //if (result)
            //{
            //    Console.WriteLine("Var");
            //}
            //else
            //{
            //    Console.WriteLine("Yoxdur");
            //}
            //TASK 22
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i < num; i++)
            //{
            //    if (i%15==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //TASK
            //int temp = 0;
            //int[] arr = { 20,-5, 65, 98, 71, 64, 11, 2, 80, 5, 6, 100, 50, 13, 9,1, 80, 454 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            temp = arr[j];
            //            arr[j] = arr[i];
            //            arr[i] = temp;
            //        }
            //    }
            //    Console.WriteLine(arr[i]);
            //}

            //TASK 
            //int[] arr = { 1, 2, 3,8, 4, 5, 6, 7, 8, 9, 10, 11 };
            //int[] arr2 = { 1, 8,12, 13, 14, 15, 16, 17,10, 18 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr2.Length; j++)
            //    {
            //        if (arr[i] == arr2[j])
            //        {
            //            Console.WriteLine(arr[i]);
            //        }
            //    }
            //}
        }
    }
}