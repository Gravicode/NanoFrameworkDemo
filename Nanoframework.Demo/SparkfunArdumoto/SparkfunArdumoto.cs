using System;
using Windows.Devices.Gpio;
using Windows.Devices.Pwm;

namespace SparkfunArdumoto
{
    public class SparkfunArdumoto
    {
        GpioPin MotorA;
        GpioPin MotorB;
        PwmPin SpeedA;
        PwmPin SpeedB;
        SparkfunArdumoto(int PinD2, int PinD4, int PinD3, int PinD11, string PWM1Id, string PWM3Id)
        {
            var GPIO = GpioController.GetDefault();

            MotorA.SetDriveMode(GpioPinDriveMode.Output);
            MotorB.SetDriveMode(GpioPinDriveMode.Output);
            MotorA = GPIO.OpenPin(PinD2);
            MotorB = GPIO.OpenPin(PinD4);

            var PWM1 = PwmController.FromId(PWM1Id);
            var PWM3 = PwmController.FromId(PWM3Id);
            SpeedA = PWM1.OpenPin(PinD3);
            SpeedB = PWM3.OpenPin(PinD11);
            PWM1.SetDesiredFrequency(5000);
            PWM3.SetDesiredFrequency(5000);

            SpeedA.Start();
            SpeedB.Start();
            ChangeSpeed(0.0, 0.0);
            ChangeDirection(MoveDirection.Forward);
        }
        public enum MoveDirection { Forward, Backward, Left, Right };
        public double SpeedValueA { get; set; }
        public double SpeedValueB { get; set; }
        public void ChangeDirection(MoveDirection Dir)
        {
            switch (Dir)
            {
                case MoveDirection.Forward:
                    {
                        MotorA.Write(GpioPinValue.High);
                        MotorB.Write(GpioPinValue.High);
                    }
                    break;
                case MoveDirection.Backward:
                    {
                        MotorA.Write(GpioPinValue.Low);
                        MotorB.Write(GpioPinValue.Low);
                    }
                    break;
                case MoveDirection.Left:
                    {
                        MotorA.Write(GpioPinValue.Low);
                        MotorB.Write(GpioPinValue.High);
                    }
                    break;
                case MoveDirection.Right:
                    {
                        MotorA.Write(GpioPinValue.High);
                        MotorB.Write(GpioPinValue.Low);
                    }
                    break;
            }

        }
        public void ChangeSpeed(double SpeedMotorA, double SpeedMotorB)
        {
            SpeedValueA = SpeedMotorA;
            SpeedValueB = SpeedMotorB;
            SpeedA.SetActiveDutyCyclePercentage(SpeedValueA);
            SpeedB.SetActiveDutyCyclePercentage(SpeedValueB);
        }

    }
}
