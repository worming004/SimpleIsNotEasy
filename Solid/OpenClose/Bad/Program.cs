namespace OpenClose
{
    class Program
    {
        static void Main(string[] args)
        {
            var avatar = new CloseAvatar();
            avatar.Move(CloseCommand.Left);
        }
    }
}
