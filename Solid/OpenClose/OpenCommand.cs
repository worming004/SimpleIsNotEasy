namespace OpenClose
{
    public interface IOpenCommand
    {
        Position Move(Position pos);
    }

    public struct MoveLeft : IOpenCommand
    {
        public Position Move(Position pos)
        {
            return new Position
            {
                x = pos.x - 1,
                y = pos.y
            };
        }
    }
    public struct MoveRight : IOpenCommand
    {
        public Position Move(Position pos)
        {
            return new Position
            {
                x = pos.x + 1,
                y = pos.y
            };
        }
    }
    public struct MoveUp : IOpenCommand
    {
        public Position Move(Position pos)
        {
            return new Position
            {
                x = pos.x,
                y = pos.y + 1

            };
        }
    }
    public struct MoveDown : IOpenCommand
    {
        public Position Move(Position pos)
        {
            return new Position
            {
                x = pos.x,
                y = pos.y - 1
            };
        }
    }
}