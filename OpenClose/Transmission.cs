namespace OpenClose
{
    internal class DefaultTransmission : ISpeedUp
    {
        internal DefaultMotor Motor { get; }

        internal DefaultTransmission(DefaultMotor motor)
        {
            Motor = motor;
        }
        public int SpeedUp()
        {
            return Motor.SpeedUp();
        }
    }
}