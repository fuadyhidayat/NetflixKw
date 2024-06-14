namespace NetflixKw.ConsoleApp;

public static class FufuProgram
{
    private static void Main()
    {
        Console.WriteLine("Hello, World!");

        var inputanUser = Console.ReadLine();

        if (inputanUser == "a")
        {
            Console.WriteLine("Inputan user adalah a");
        }
        else if (inputanUser == "b")
        {
            Console.WriteLine("Inputan user adalah b");
        }
        else
        {
            Console.WriteLine("Inputan user bukan a atau b");
        }

        var abc = 7;
        var xyz = 9;

        Console.WriteLine($"Isi abc: {abc}");
        Console.WriteLine($"Isi xyz: {xyz}");
    }
}