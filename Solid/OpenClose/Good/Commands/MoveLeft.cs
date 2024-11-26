namespace OpenClose.Commands
{
    public struct MoveLeft : ICommand
    {
        public Position Move(Position pos)
        {
            return new Position
            {
                X = pos.X - 1,
                Y = pos.Y
            };
        }
    }
}
