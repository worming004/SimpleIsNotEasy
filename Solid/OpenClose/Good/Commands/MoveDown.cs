namespace OpenClose.Commands
{
    public struct MoveDown : ICommand
    {
        public Position Move(Position pos)
        {
            return new Position
            {
                X = pos.X,
                Y = pos.Y - 1
            };
        }
    }
}
