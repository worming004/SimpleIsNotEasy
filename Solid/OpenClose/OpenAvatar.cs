namespace OpenClose
{
    public class OpenAvatar
    {
        public Position pos { get; set; }

        public void MoveWithCommand(IOpenCommand command)
        {
            this.pos = command(pos);
        }
    }
}