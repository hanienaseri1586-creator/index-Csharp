using System;

class Program
{
    static void Main()
    {
        
        Console.Write("leghenth rectangele ");
        int length = int.Parse(Console.ReadLine());

         
        Console.Write("width rectangele: ");
        int width = int.Parse(Console.ReadLine());


        if (length > 0 && width > 0)
        {
            int area = length * width;
            int perimeter = 2 * (length + width);

            Console.WriteLine("area rectangele: " + area);
            Console.WriteLine("perimeter rectangele: " + perimeter);
        }
        else
        {
            Console.WriteLine("خطا! لطفاً عدد مثبت وارد .");
        }
    }
}
