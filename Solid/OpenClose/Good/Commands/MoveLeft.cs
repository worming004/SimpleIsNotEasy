namespace OpenClose.Commands
{
    public struct MoveLeft : ICommand
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
}
