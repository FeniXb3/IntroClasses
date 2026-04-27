namespace IntroClasses;

public class Player
{
    private int _x;
    private int _y;
    private string _avatar = "@";

    public void Display()
    {
        Console.SetCursorPosition(_x, _y);
        Console.Write(_avatar);
    }

    public void Move(int diffX, int diffY)
    {
        int targetX = _x + diffX;
        int targetY = _y + diffY;

        if (targetX >= 0 && targetX < Console.BufferWidth)
        {
            _x = targetX;
        }

        if (targetY >= 0 && targetY < Console.BufferHeight)
        {
            _y = targetY;
        }
    }

    public bool TakeTurn()
    {
        var isPlaying = IsPlaying(out var input);
        switch (input.Key)
        {
            case ConsoleKey.S:
                Move(0, 1);
                break;
            case ConsoleKey.W:
                Move(0, -1);
                break;
            case ConsoleKey.A:
                Move(-1, 0);
                break;
            case ConsoleKey.D:
                Move(1, 0);
                break;
            case ConsoleKey.Q:
                isPlaying = false;
                break;
        }

        Display();
        
        return isPlaying;
    }

    private bool IsPlaying(out ConsoleKeyInfo input)
    {
        bool isPlaying = true;
        input = Console.ReadKey(true);
        Console.SetCursorPosition(_x, _y);
        Console.Write(" ");
        return isPlaying;
    }
}
