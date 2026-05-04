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
        Move(1, 0);
        Display();
        return true;
    }
}