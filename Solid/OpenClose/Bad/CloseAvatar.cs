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
                    this.pos.X--;
                    break;
                case CloseCommand.Right:
                    this.pos.X++;
                    break;
                default:
                    break;
            }
        }
    }
}
