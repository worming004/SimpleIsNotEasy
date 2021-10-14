namespace OpenClose
{
    public enum CloseCommand
    {
        Left,
        Right
    }
    public class CloseAvatar
    {
        private Position pos;

        public void Move(CloseCommand command)
        {
            switch (command)
            {
                case CloseCommand.Left:
                    this.pos.x--;
                case CloseCommand.Right:
                    this.pos.x++;
                default:
            }
        }
    }
}