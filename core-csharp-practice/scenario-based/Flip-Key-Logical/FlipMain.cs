public class FlipMain
{
    public static void Main(string[] args)
    {
        FlipUtiity flip = new FlipUtiity();
        Console.WriteLine("-- Welcome To Flip Key ----");
        Console.WriteLine("------  Enter Your String Here -------");
        string input = Console.ReadLine();
       string output = flip.CleanseAndInvert(input);
       Console.WriteLine(output);
    }
}