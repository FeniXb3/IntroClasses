namespace IntroClasses;

public abstract class Character : GameObject
{
    protected Inventory _inventory;
    
    public Character(char avatar, Vector2 startingPosition, Map map) : base(avatar, startingPosition)
    {
        _inventory = new Inventory();
        Cell cell = map.GetCell(_position.X, _position.Y);
        cell.Occupant = this;
    }

    public bool Move(Vector2 direction, Map map)
    {
        return Move(direction.X, direction.Y, map);
    }

    public bool Move(int diffX, int diffY, Map map)
    {
        int targetX = _position.X + diffX;
        int targetY = _position.Y + diffY;

        if (targetY >= 0 && targetY < Console.BufferHeight && targetY < map.GetHeight())
        {
            if (targetX >= 0 && targetX < Console.BufferWidth && targetX < map.GetRowWidth(targetY))
            {
                Cell cell = map.GetCell(targetX, targetY);
                if (cell.Visuals == '#' || cell.IsOccupied() || (cell.Visuals == '|' && !_inventory.Has('*')))
                {
                    return false;
                }

                if (cell.Visuals == '|' && _inventory.Has('*'))
                {
                    RemoveItemByAvatar('*');
                }
                
                _position.Y = targetY;
                _position.X = targetX;
                    
                cell.Occupy(this);
                if (cell.HasItem())
                {
                    // Item item = cell.TakeItem();
                    // AddItem(item);
                    AddItem(cell.TakeItem());
                }
                return true;
            }
        }

        return false;
    }

    private void RemoveItemByAvatar(char c)
    {
        _inventory.RemoveItemByAvatar(c);
    }

    public void AddItem(Item item)
    {
        _inventory.Add(item);
    }

    public abstract bool TakeTurn(Map map);
}