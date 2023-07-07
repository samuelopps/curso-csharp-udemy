using Extensions.Extensions;

public class ProcessFile
{
    public static void Main()
    {
        DateTime dt = new DateTime(2022, 10, 26, 8, 10, 45);
        Console.WriteLine(dt.ElapsedTime());

        String s1 = "Good morning dear students!";
        Console.WriteLine(s1.Cut(10));

        Console.ReadLine();
    }
}