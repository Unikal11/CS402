using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace CS402
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {






//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        double sayi1 = 9;
//        double sayi2 = 5;

//        double netice = SumTwoNumbers(sayi1, sayi2);

//        Console.WriteLine("İki ededin cemi: " + netice);
//    }

//    public static double SumTwoNumbers(double sayi1, double sayi2)
//    {
//        double toplam = sayi1 + sayi2;
//        return toplam;
//    }
//}




//class Program
//{
//    static void Main()
//    {
//        double number1 = 5;
//        double number2 = 4;

//        double result = CalculateProductOfDifferenceAndSum(number1, number2);

//        Console.WriteLine("iki ededin cemi ile ferqinin hasili: " + result);
//    }

//    public static double CalculateProductOfDifferenceAndSum(double num1, double num2)
//    {
//        double difference = num1 - num2;
//        double sum = num1 + num2;
//        double product = difference * sum;

//        return product;
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        string[] words = { "salam", "masin", "buz", "ev", "kod", "Meymun", "avtobus" };

//        for (int i = 0; i < words.Length; i++)
//        {
//            if (words[i].Length < 4)
//            {
//                words[i] = "[" + words[i] + "]";
//            }
//        }

//        string result = string.Join(" ", words);
//        Console.WriteLine(result);
//    }
//}




//class Program
//{
//    static void Main()
//    {
//        string[] words = { "salam", "masin", "buz", "ev", "kod", "Meymun", "avtobus" };

//        for (int i = 0; i < words.Length; i++)
//        {
//            if (words[i].Length > 4)
//            {
//                words[i] += "AZE";
//            }
//        }

//        string result = string.Join(" ", words);
//        Console.WriteLine(result);
//    }
//}



//class Program
//{
//    static void Main()
//    {
//        string[] words = { "salam", "masin", "buz", "ev", "kod", "Meymun", "avtobus" };

//        for (int i = 0; i < words.Length; i++)
//        {
//            words[i] = "[" + words[i] + "]";
//        }

//        Console.WriteLine(string.Join(" ", words));
//    }
//}




//class Program
//{
//    static void Main()
//    {
//        string[] words = { "salam", "masin", "buz", "ev", "kod", "Meymun", "avtobus" };

//        string result = string.Join(" ", words);
//        Console.WriteLine(result);
//    }
//}



//class Program
//{
//    static void Main()
//    {
//        for (int i = 0; i <= 100; i++)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}




//class Program
//{
//    static void Main()
//    {
//        for (int i = 0; i <= 100; i += 2)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}



//class Program
//{
//    static void Main()
//    {
//        int toplam = 0;

//        for (int i = 1; i <= 100; i += 2)
//        {
//            toplam += i;
//        }

//        Console.WriteLine("0 ile 100 arasindaki ededlerin cemi: " + toplam);
//    }
//}



//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("reqemleri bir-birine beraber olan iki reqemli ededler:");

//        for (int i = 10; i <= 99; i++)
//        {
//            int birinciReqem = i / 10;
//            int ikinciReqem = i % 10;

//            if (birinciReqem == ikinciReqem)
//            {
//                Console.WriteLine(i);
//            }
//        }
//    }
//}



//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 1, 2, 3, 4, 5 };
//        string[] names = { "f10", "f30", "m5", "m3" };

//        PrintFirstElement(numbers);
//        PrintFirstElement(names);
//    }

//    public static void PrintFirstElement<T>(T[] array)
//    {
//        if (array.Length > 0)
//        {
//            Console.WriteLine("İlk element: " + array[0]);
//        }
//        else
//        {
//            Console.WriteLine(" boş.");
//        }
//    }
//}



//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 1, 2, 3, 4, 5 };
//        string[] names = { "bmw", "mersedes", "lada", "nissan" };

//        PrintLastElement(numbers);
//        PrintLastElement(names);
//    }

//    public static void PrintLastElement<T>(T[] array)
//    {
//        if (array.Length > 0)
//        {
//            Console.WriteLine("Son element: " + array[array.Length - 1]);
//        }
//        else
//        {
//            Console.WriteLine(" boş.");
//        }
//    }
//}
