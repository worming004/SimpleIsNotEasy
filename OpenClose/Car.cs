namespace OpenClose
{

    internal class Car : ISpeedUp
    {
        internal DefaultGearBox GearBox { get; }

        internal Car(DefaultGearBox gearbox)
        {
            GearBox = gearbox;
        }

        public int SpeedUp()
        {
            var newGearBoxValue = GearBox.SpeedUp();
            PrintGearBoxSpeed(newGearBoxValue);
            return newGearBoxValue;
        }

        internal void PrintGearBoxSpeed(int value)
        {
            // Print here in system board
            System.Console.WriteLine($"new gearbox speed: {value}");
        }

        internal static Car BuildCar()
        {
            var motor = new DefaultMotor();
            var transmission = new DefaultTransmission(motor);
            var gearBox = new DefaultGearBox(transmission);
            return new Car(gearBox);
        }
    }
}