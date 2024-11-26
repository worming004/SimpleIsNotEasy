using OpenClose.Commands;

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
                    new Position { X = 2, Y = 5 }
                )
            );
        }
    }

    class PositionPrinter
    {
        public void Print(Position p)
        {
            System.Console.WriteLine($"x: {p.X}, y: {p.Y}");
        }
    }
}
