using OpenClose.Commands;

namespace OpenClose
{
    public class OpenAvatar
    {
        public Position pos { get; set; }

        public void MoveWithCommand(ICommand command)
        {
            this.pos = command.Move(pos);
        }
    }
}
