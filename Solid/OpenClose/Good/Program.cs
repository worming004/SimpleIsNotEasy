using System;

namespace OpenClose
{
    class Program
    {
        static void Main(string[] args)
        {
            var avatar = new OpenAvatar();
            avatar.MoveWithCommand(new MoveLeft());

            avatar.MoveWithCommand(
                new TeleportTo(
                    new Position { x = 2, y = 5 }
                )
            );
        }
    }

    // Implemente une nouvelle façon de se déplacer
    public class TeleportTo : IOpenCommand
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
