namespace OpenClose {
    class DefaultMotor : ISpeedUp {
        internal int VitessePosition { get; set; }

        public int SpeedUp () {
            return ++VitessePosition;
        }
    }
}