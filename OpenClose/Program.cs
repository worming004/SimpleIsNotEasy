using System;

namespace OpenClose {
    class Program {
        static void Main (string[] args) {
            var car = Car.BuildCar ();

            // my program
            // [...]

            // Not extensible because of Demeter law. If we move to an automatic car => difficult to refactor
            // When driver choose to speed up, the driver itself have to change himself the board system. 
            //      Does it make sense to you ?
            car.GearBox.Transmission.Motor.VitessePosition++;
            car.PrintGearBoxSpeed (car.GearBox.Transmission.Motor.VitessePosition);
            // [...]

            // Same, but abstract everything.
            // Now when driver change the speed level, he does't care about any piece of the car.
            // It also means that any part of the car can be changed easily. Electric car ?
            car.SpeedUp ();
            // [...]
        }
    }
}