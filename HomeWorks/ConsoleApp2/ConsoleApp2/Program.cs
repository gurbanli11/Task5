namespace ConsoleApp2
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
            //TASK 5
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
            //TASK 22
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i < num; i++)
            //{
            //    if (i%15==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

        }
    }
}