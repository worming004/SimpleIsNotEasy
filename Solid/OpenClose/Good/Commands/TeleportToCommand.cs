namespace OpenClose.Commands
{
    // Implemente une nouvelle façon de se déplacer
    public class TeleportTo : ICommand
    {
        private Position _position;
        public TeleportTo(Position pos)
        {
            _position = pos;
        }
        public Position Move(Position _)
        {
            return _position;
        }
    }
}
