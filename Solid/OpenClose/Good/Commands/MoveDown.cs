namespace OpenClose.Commands
{
    public struct MoveDown : ICommand
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
