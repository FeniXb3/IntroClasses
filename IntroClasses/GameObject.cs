namespace IntroClasses;

public abstract class GameObject
{
    protected Vector2 _position = new Vector2(0, 0);
    protected char _avatar = '@';

    public char GetAvatar()
    {
        return _avatar;
    }

    public GameObject(char avatar, Vector2 position)
    {
        _avatar = avatar;
        _position = position;
    }
    
    public void Display()
    {
        Display(_position);
    }

    public void Display(Vector2 screenPosition)
    {
        Console.SetCursorPosition(screenPosition.X, screenPosition.Y);
        Console.Write(_avatar);
    }
}