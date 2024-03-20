using EventsMyCSharp;
using Lab9_10CharpT;
using System.Collections;
using System.Threading.Tasks;

Console.WriteLine("Lab#9  or  Lab#10");

while (true)
{
    Console.Write("Select a task (1,2), 0 - exit : ");
    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            task1 task11 = new task1();
            task11.information();
            break;

        case "2":
            task2 task22 = new task2();
            task22.town();
            break;

        case "0":
            return;

        default:
            Console.WriteLine("Error");
            break;
    }
}

class task1
{
    public void information()
    {
        Console.WriteLine("--------------------------------------Task1--------------------------------------");

        // Our exception
        Console.WriteLine("Our exception");
        try
        {
            Lab9_10CharpT.Rectangle wrongRectangle = new Lab9_10CharpT.Rectangle(-10, 60);

        }
        catch (InvalidException ex)
        {
            Console.WriteLine($"Спрацювала наша виняткова ситуацiя: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Загальна помилка: {ex.Message}");
        }
        Console.WriteLine("---------------------------------------------------------------------------------");

        // ArrayTypeMismatchException
        Console.WriteLine("ArrayTypeMismatchException");
        try
        {
            string[] names = { "Hello world", "!!!" };
            Object[] objs = (Object[])names;

            Object obj = (Object)13;

            objs[1] = obj;
        }
        catch (ArrayTypeMismatchException ex)
        {
            Console.WriteLine($"Помилка ArrayTypeMismatchException: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Загальна помилка: {ex.Message}");
        }
        Console.WriteLine("---------------------------------------------------------------------------------");

        // DivideByZeroException
        Console.WriteLine("DivideByZeroException");
        try
        {
            int a = 10;
            int b = 0;

            int result = a / b;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Помилка DivideByZeroException: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Загальна помилка: {ex.Message}");
        }
        Console.WriteLine("---------------------------------------------------------------------------------");

        // IndexOutOfRangeException
        Console.WriteLine("IndexOutOfRangeException");
        try
        {
            int[] array = { 1, 2, 3 };

            int element = array[3];
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Помилка IndexOutOfRangeException: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Загальна помилка: {ex.Message}");
        }
        Console.WriteLine("---------------------------------------------------------------------------------");

        // InvalidCastException
        Console.WriteLine("InvalidCastException");
        try
        {
            object obj = "123";
            int number = (int)obj;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Помилка InvalidCastException: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Загальна помилка: {ex.Message}");
        }
        Console.WriteLine("---------------------------------------------------------------------------------");

        // OutOfMemoryException
        Console.WriteLine("OutOfMemoryException");
        try
        {
            int[] array = new int[int.MaxValue];
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Помилка OutOfMemoryException: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Загальна помилка: {ex.Message}");
        }
        Console.WriteLine("---------------------------------------------------------------------------------");

        // OverflowException
        Console.WriteLine("OverflowException");
        try
        {
            int maxValue = int.MaxValue;
            int result = checked(maxValue + 1);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Помилка OverflowException: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Загальна помилка: {ex.Message}");
        }
        Console.WriteLine("---------------------------------------------------------------------------------");

        // StackOverflowException
        Console.WriteLine("StackOverflowException");
        try
        {

            void func()
            {
                func();
            }

            // func();

            throw new StackOverflowException();
        }
        catch (StackOverflowException ex)
        {
            Console.WriteLine($"Помилка StackOverflowException: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Загальна помилка: {ex.Message}");
        }
        Console.WriteLine("---------------------------------------------------------------------------------");
    }
}

class task2
{
    public void town()
    {
        NewTown sometown1 = new NewTown("New York", 50, 50);
        NewTown sometown2 = new NewTown("Київ", 50, 100);
        NewTown sometown3 = new NewTown("Варшава", 10, 100);

        sometown1.LifeOurTown();
        sometown2.LifeOurTown();
        sometown3.LifeOurTown();
    }
}
