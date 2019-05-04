namespace OpenClose{
    internal class DefaultGearBox : ISpeedUp {
        internal DefaultTransmission Transmission {get;}

        internal DefaultGearBox (DefaultTransmission transmission){
            Transmission = transmission;
        }
        public int SpeedUp(){
            return Transmission.SpeedUp();
        }
    }
}