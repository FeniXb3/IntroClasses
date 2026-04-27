namespace IntroClasses;

public class Program
{
    public static void Main()
    {
        bool isPlaying = true;
        Vector2 startingPosition = new Vector2(4, 2);
        Player hero = new Player(startingPosition);
        startingPosition.X = 0;
        startingPosition.Y = 0;
        // startingPosition = new Vector2(0, 0);
        Player anotherHero = new Player(startingPosition);
        
        hero.Display();
        anotherHero.Display();
        while (isPlaying)
        {
            isPlaying = hero.TakeTurn();
            isPlaying = anotherHero.TakeTurn();
        }
        
        Console.WriteLine("Goodbye!");
    }
}