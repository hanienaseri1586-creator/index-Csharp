using System;

class Program
{
    static void Main()
    {
        // گرفتن طول
        Console.Write("طول مستطیل را وارد کنید: ");
        int length = int.Parse(Console.ReadLine());

        // گرفتن عرض
        Console.Write("عرض مستطیل را وارد کنید: ");
        int width = int.Parse(Console.ReadLine());

        // بررسی مثبت بودن و چاپ نتیجه
        if (length > 0 && width > 0)
        {
            int area = length * width;
            int perimeter = 2 * (length + width);

            Console.WriteLine("مساحت مستطیل: " + area);
            Console.WriteLine("محیط مستطیل: " + perimeter);
        }
        else
        {
            Console.WriteLine("خطا! لطفاً عدد مثبت وارد کنید.");
        }
    }
}
