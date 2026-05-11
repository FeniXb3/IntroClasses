namespace IntroClasses;

public class Player : Character
{
    private readonly Dictionary<ConsoleKey, Vector2> _inputMap;

    public Player(Vector2 startingPosition, Dictionary<ConsoleKey, Vector2> inputMap) : base(startingPosition)
    {
        _inputMap = inputMap;
    }

    public override bool TakeTurn()
    {
        var isPlaying = IsPlaying(out var input);

        if (_inputMap.ContainsKey(input.Key))
        {
            Vector2 direction = _inputMap[input.Key];
            Move(direction);
        }
        else
        {
            switch (input.Key)
            {
                case ConsoleKey.Q:
                    isPlaying = false;
                    break;
            }
        }

        Display();
        
        return isPlaying;
    }

    private bool IsPlaying(out ConsoleKeyInfo input)
    {
        bool isPlaying = true;
        input = Console.ReadKey(true);
        Console.SetCursorPosition(_position.X, _position.Y);
        Console.Write(" ");
        return isPlaying;
    }
}
