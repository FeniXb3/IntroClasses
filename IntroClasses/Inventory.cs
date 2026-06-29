namespace IntroClasses;

public class Inventory
{
    private List<Item> _items = [];

    public void Add(Item item)
    {
        _items.Add(item);
    }

    public void Display()
    {
        int x = 30;
        int y = 0;
        Console.SetCursorPosition(x, y);
        Console.WriteLine("Inventory:");
        y++;
        foreach (Item item in _items)
        {
            item.Display(new Vector2(x,y));
            y++;
        }
    }

    public void Hide()
    {
        int x = 30;
        for (int y = 0; y < _items.Count + 1; y++)
        {
            Console.SetCursorPosition(x,y);
            Console.WriteLine("                        ");
        }
    }

    public bool Has(char itemAvatar)
    {
        // foreach (Item item in _items)
        // {
        //     if (item.GetAvatar() == itemAvatar)
        //     {
        //         return true;
        //     }
        // }
        // return false;
        
        // return _items.Any(item =>
        // {
        //     return item.GetAvatar() == itemAvatar;
        // });
        
        return _items.Any(item => item.GetAvatar() == itemAvatar);
    }
}