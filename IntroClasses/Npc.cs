namespace IntroClasses;

public class Npc : Character
{
    public Npc(Vector2 startingPosition) : base(startingPosition)
    {
        
    }

    public override bool TakeTurn()
    {
        Console.SetCursorPosition(_position.X, _position.Y);
        Console.Write(" ");
        int targetX = Random.Shared.Next(-1, 2);
        int targetY = Random.Shared.Next(-1, 2);
        Move(targetX, targetY);
        Display();
        return true;
    }
}