namespace OpenClose.Commands
{
    public struct MoveUp : ICommand
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
}
