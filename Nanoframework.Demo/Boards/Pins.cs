using System;

namespace Boards
{
    public static class Netduino3
    {
        /// <summary>GPIO pin definitions.</summary>
        public static class GpioPin
        {

            /// <summary>Debug LED definition</summary>
            public const int Led = STM32F4.GpioPin.PA10;
            public const int PowerLed = STM32F4.GpioPin.PC13;

            /// <summary>SD Card Dectect definition</summary>
            public const int SdCardDetect = STM32F4.GpioPin.PB2;
            public const int SdCardPwrCtrl = STM32F4.GpioPin.PB1;

            /// <summary>GPIO pin.</summary>
            public const int D0 = STM32F4.GpioPin.PC7;
            /// <summary>GPIO pin.</summary>
            public const int D1 = STM32F4.GpioPin.PC6;
            /// <summary>GPIO pin.</summary>
            public const int D2 = STM32F4.GpioPin.PA3;
            /// <summary>GPIO pin.</summary>
            public const int D3 = STM32F4.GpioPin.PA2;
            /// <summary>GPIO pin.</summary>
            public const int D4 = STM32F4.GpioPin.PB12;
            /// <summary>GPIO pin.</summary>
            public const int D5 = STM32F4.GpioPin.PB8;
            /// <summary>GPIO pin.</summary>
            public const int D6 = STM32F4.GpioPin.PB9;
            /// <summary>GPIO pin.</summary>
            public const int D7 = STM32F4.GpioPin.PA1;
            /// <summary>GPIO pin.</summary>
            public const int D8 = STM32F4.GpioPin.PA0;
            /// <summary>GPIO pin.</summary>
            public const int D9 = STM32F4.GpioPin.PE5;
            /// <summary>GPIO pin.</summary>
            public const int D10 = STM32F4.GpioPin.PB10;
            /// <summary>GPIO pin.</summary>
            public const int D11 = STM32F4.GpioPin.PB15;
            /// <summary>GPIO pin.</summary>
            public const int D12 = STM32F4.GpioPin.PB14;
            /// <summary>GPIO pin.</summary>
            public const int D13 = STM32F4.GpioPin.PB13;
            /// <summary>GPIO pin.</summary>
            public const int A0 = STM32F4.GpioPin.PC0;
            /// <summary>GPIO pin.</summary>
            public const int A1 = STM32F4.GpioPin.PC1;
            /// <summary>GPIO pin.</summary>
            public const int A2 = STM32F4.GpioPin.PC2;
            /// <summary>GPIO pin.</summary>
            public const int A3 = STM32F4.GpioPin.PC3;
            /// <summary>GPIO pin.</summary>
            public const int A4 = STM32F4.GpioPin.PC4;
            /// <summary>GPIO pin.</summary>
            public const int A5 = STM32F4.GpioPin.PC5;

            /// <summary>Socket definition.</summary>
            public static class GoPort1
            {
                /// <summary>Pin definition.</summary>
                public const int Pin3 = STM32F4.GpioPin.PD13;
                /// <summary>Pin definition.</summary>
                public const int Pin4 = STM32F4.GpioPin.PD8;
                /// <summary>Pin definition.</summary>
                public const int Pin5 = STM32F4.GpioPin.PD9;
                /// <summary>Pin definition.</summary>
                public const int Pin6 = STM32F4.GpioPin.PD0;
                /// <summary>LED definition.</summary>
                public const int Led = STM32F4.GpioPin.PE9;
                /// <summary>Power On definition.</summary>
                public const int PwrOn = STM32F4.GpioPin.PD7;
            }

            /// <summary>Socket definition.</summary>
            public static class GoPort2
            {
                /// <summary>Pin definition.</summary>
                public const int Pin3 = STM32F4.GpioPin.PD14;
                /// <summary>Pin definition.</summary>
                public const int Pin4 = STM32F4.GpioPin.PE8;
                /// <summary>Pin definition.</summary>
                public const int Pin5 = STM32F4.GpioPin.PE7;
                /// <summary>Pin definition.</summary>
                public const int Pin6 = STM32F4.GpioPin.PD1;
                /// <summary>LED definition.</summary>
                public const int Led = STM32F4.GpioPin.PE11;
                /// <summary>Power On definition.</summary>
                public const int PwrOn = STM32F4.GpioPin.PD10;
            }

            /// <summary>Socket definition.</summary>
            public static class GoPort3
            {
                /// <summary>Pin definition.</summary>
                public const int Pin3 = STM32F4.GpioPin.PD15;
                /// <summary>Pin definition.</summary>
                public const int Pin4 = STM32F4.GpioPin.PE1;
                /// <summary>Pin definition.</summary>
                public const int Pin5 = STM32F4.GpioPin.PE0;
                /// <summary>Pin definition.</summary>
                public const int Pin6 = STM32F4.GpioPin.PD2;
                /// <summary>LED definition.</summary>
                public const int Led = STM32F4.GpioPin.PB0;
                /// <summary>Power On definition.</summary>
                public const int PwrOn = STM32F4.GpioPin.PE14;
            }
        }

        /// <summary>Analog channel definition.</summary>
        public static class AdcChannel
        {
            /// <summary>Pin definition.</summary>
            public const int A0 = STM32F4.AdcChannel.Channel10;
            /// <summary>Pin definition.</summary>
            public const int A1 = STM32F4.AdcChannel.Channel11;
            /// <summary>Pin definition.</summary>
            public const int A2 = STM32F4.AdcChannel.Channel12;
            /// <summary>Pin definition.</summary>
            public const int A3 = STM32F4.AdcChannel.Channel13;
            /// <summary>Pin definition.</summary>
            public const int A4 = STM32F4.AdcChannel.Channel14;
            /// <summary>Pin definition.</summary>
            public const int A5 = STM32F4.AdcChannel.Channel15;
        }

        /// <summary>Uart port definition.</summary>
        public static class UartPort
        {

            /// <summary>Socket definition.</summary>
            public const string GoPort1 = STM32F4.UartPort.Usart3;
            /// <summary>Socket definition.</summary>
            public const string GoPort2 = STM32F4.UartPort.Uart7;
            /// <summary>Socket definition.</summary>
            public const string GoPort3 = STM32F4.UartPort.Uart8;

            /// <summary>UART D0 (RX) and D1 (TX).</summary>
            //public const string Uart6 = STM32F4.UartPort.Uart6;
        }

        /// <summary>SPI Bus definition.</summary>
        public static class SpiBus
        {

            /// <summary>Socket definition.</summary>
            public const string GoPort1 = STM32F4.SpiBus.Spi4;
            public const string GoPort2 = STM32F4.SpiBus.Spi4;
            public const string GoPort3 = STM32F4.SpiBus.Spi4;
            public const string Spi2 = STM32F4.SpiBus.Spi2;
        }
        public static class PwmPin
        {
            public static class Controller1
            {
                public const string Id = "TIM0";
                public const int D3 = 0;
                public const int D1 = 1;
                public const int D0 = 2;
            }

            public static class Controller3
            {
                public const string Id = "TIM1";//"TIM2";
                public const int D6 = 0;
                public const int D11 = 1;
                public const int D10 = 2;
                public const int D9 = 3;
            }

            public static class Controller4
            {
                public const string Id = "TIM3";
                public const int Scl = 0;
                public const int Sda = 1;
                public const int D5 = 2;
                public const int Led1 = 3;
            }
        }
        public static class I2cBus
        {
            public const string I2c1 = "I2C1";
        }
    }
    public static class STM32F4
    {
        public static class GpioPin
        {
            public const string Id = "GHIElectronics.TinyCLR.NativeApis.STM32F4.GpioProvider\\0";
            public const int PA0 = 0;
            public const int PA1 = 1;
            public const int PA2 = 2;
            public const int PA3 = 3;
            public const int PA4 = 4;
            public const int PA5 = 5;
            public const int PA6 = 6;
            public const int PA7 = 7;
            public const int PA8 = 8;
            public const int PA9 = 9;
            public const int PA10 = 10;
            public const int PA11 = 11;
            public const int PA12 = 12;
            public const int PA13 = 13;
            public const int PA14 = 14;
            public const int PA15 = 15;
            public const int PB0 = 16;
            public const int PB1 = 17;
            public const int PB2 = 18;
            public const int PB3 = 19;
            public const int PB4 = 20;
            public const int PB5 = 21;
            public const int PB6 = 22;
            public const int PB7 = 23;
            public const int PB8 = 24;
            public const int PB9 = 25;
            public const int PB10 = 26;
            public const int PB11 = 27;
            public const int PB12 = 28;
            public const int PB13 = 29;
            public const int PB14 = 30;
            public const int PB15 = 31;
            public const int PC0 = 32;
            public const int PC1 = 33;
            public const int PC2 = 34;
            public const int PC3 = 35;
            public const int PC4 = 36;
            public const int PC5 = 37;
            public const int PC6 = 38;
            public const int PC7 = 39;
            public const int PC8 = 40;
            public const int PC9 = 41;
            public const int PC10 = 42;
            public const int PC11 = 43;
            public const int PC12 = 44;
            public const int PC13 = 45;
            public const int PC14 = 46;
            public const int PC15 = 47;
            public const int PD0 = 48;
            public const int PD1 = 49;
            public const int PD2 = 50;
            public const int PD3 = 51;
            public const int PD4 = 52;
            public const int PD5 = 53;
            public const int PD6 = 54;
            public const int PD7 = 55;
            public const int PD8 = 56;
            public const int PD9 = 57;
            public const int PD10 = 58;
            public const int PD11 = 59;
            public const int PD12 = 60;
            public const int PD13 = 61;
            public const int PD14 = 62;
            public const int PD15 = 63;
            public const int PE0 = 64;
            public const int PE1 = 65;
            public const int PE2 = 66;
            public const int PE3 = 67;
            public const int PE4 = 68;
            public const int PE5 = 69;
            public const int PE6 = 70;
            public const int PE7 = 71;
            public const int PE8 = 72;
            public const int PE9 = 73;
            public const int PE10 = 74;
            public const int PE11 = 75;
            public const int PE12 = 76;
            public const int PE13 = 77;
            public const int PE14 = 78;
            public const int PE15 = 79;
            public const int PF0 = 80;
            public const int PF1 = 81;
            public const int PF2 = 82;
            public const int PF3 = 83;
            public const int PF4 = 84;
            public const int PF5 = 85;
            public const int PF6 = 86;
            public const int PF7 = 87;
            public const int PF8 = 88;
            public const int PF9 = 89;
            public const int PF10 = 90;
            public const int PF11 = 91;
            public const int PF12 = 92;
            public const int PF13 = 93;
            public const int PF14 = 94;
            public const int PF15 = 95;
            public const int PG0 = 96;
            public const int PG1 = 97;
            public const int PG2 = 98;
            public const int PG3 = 99;
            public const int PG4 = 100;
            public const int PG5 = 101;
            public const int PG6 = 102;
            public const int PG7 = 103;
            public const int PG8 = 104;
            public const int PG9 = 105;
            public const int PG10 = 106;
            public const int PG11 = 107;
            public const int PG12 = 108;
            public const int PG13 = 109;
            public const int PG14 = 110;
            public const int PG15 = 111;
            public const int PH0 = 112;
            public const int PH1 = 113;
            public const int PH2 = 114;
            public const int PH3 = 115;
            public const int PH4 = 116;
            public const int PH5 = 117;
            public const int PH6 = 118;
            public const int PH7 = 119;
            public const int PH8 = 120;
            public const int PH9 = 121;
            public const int PH10 = 122;
            public const int PH11 = 123;
            public const int PH12 = 124;
            public const int PH13 = 125;
            public const int PH14 = 126;
            public const int PH15 = 127;
            public const int PI0 = 128;
            public const int PI1 = 129;
            public const int PI2 = 130;
            public const int PI3 = 131;
            public const int PI4 = 132;
            public const int PI5 = 133;
            public const int PI6 = 134;
            public const int PI7 = 135;
            public const int PI8 = 136;
            public const int PI9 = 137;
            public const int PI10 = 138;
            public const int PI11 = 139;
            public const int PI12 = 140;
            public const int PI13 = 141;
            public const int PI14 = 142;
            public const int PI15 = 143;
            public const int PJ0 = 144;
            public const int PJ1 = 145;
            public const int PJ2 = 146;
            public const int PJ3 = 147;
            public const int PJ4 = 148;
            public const int PJ5 = 149;
            public const int PJ6 = 150;
            public const int PJ7 = 151;
            public const int PJ8 = 152;
            public const int PJ9 = 153;
            public const int PJ10 = 154;
            public const int PJ11 = 155;
            public const int PJ12 = 156;
            public const int PJ13 = 157;
            public const int PJ14 = 158;
            public const int PJ15 = 159;
            public const int PK0 = 160;
            public const int PK1 = 161;
            public const int PK2 = 162;
            public const int PK3 = 163;
            public const int PK4 = 164;
            public const int PK5 = 165;
            public const int PK6 = 166;
            public const int PK7 = 167;
            public const int PK8 = 168;
            public const int PK9 = 169;
            public const int PK10 = 170;
            public const int PK11 = 171;
            public const int PK12 = 172;
            public const int PK13 = 173;
            public const int PK14 = 174;
            public const int PK15 = 175;
        }

        public static class AdcChannel
        {
            public const string Id = "GHIElectronics.TinyCLR.NativeApis.STM32F4.AdcProvider\\0";
            public const int Channel0 = 0;
            public const int Channel1 = 1;
            public const int Channel2 = 2;
            public const int Channel3 = 3;
            public const int Channel4 = 4;
            public const int Channel5 = 5;
            public const int Channel6 = 6;
            public const int Channel7 = 7;
            public const int Channel8 = 8;
            public const int Channel9 = 9;
            public const int Channel10 = 10;
            public const int Channel11 = 11;
            public const int Channel12 = 12;
            public const int Channel13 = 13;
            public const int Channel14 = 14;
            public const int Channel15 = 15;
            public const int Channel16 = 16;
            public const int Channel17 = 16;
            public const int Channel18 = 18;
        }

        public static class DacChannel
        {
            public const string Id = "GHIElectronics.TinyCLR.NativeApis.STM32F4.DacProvider\\0";
            public const int Channel1 = 0;
            public const int Channel2 = 1;
        }

        public static class PwmPin
        {
            public const string Tim1 = "GHIElectronics.TinyCLR.NativeApis.STM32F4.PwmProvider\\0";
            public const string Tim2 = "GHIElectronics.TinyCLR.NativeApis.STM32F4.PwmProvider\\1";
            public const string Tim3 = "GHIElectronics.TinyCLR.NativeApis.STM32F4.PwmProvider\\2";
            public const string Tim4 = "GHIElectronics.TinyCLR.NativeApis.STM32F4.PwmProvider\\3";
            public const string Tim5 = "GHIElectronics.TinyCLR.NativeApis.STM32F4.PwmProvider\\4";
            public const string Tim6 = "GHIElectronics.TinyCLR.NativeApis.STM32F4.PwmProvider\\5";
            public const string Tim7 = "GHIElectronics.TinyCLR.NativeApis.STM32F4.PwmProvider\\6";
            public const string Tim8 = "GHIElectronics.TinyCLR.NativeApis.STM32F4.PwmProvider\\7";
            public const string Tim9 = "GHIElectronics.TinyCLR.NativeApis.STM32F4.PwmProvider\\8";
            public const string Tim10 = "GHIElectronics.TinyCLR.NativeApis.STM32F4.PwmProvider\\9";
            public const string Tim11 = "GHIElectronics.TinyCLR.NativeApis.STM32F4.PwmProvider\\10";
            public const string Tim12 = "GHIElectronics.TinyCLR.NativeApis.STM32F4.PwmProvider\\11";
            public const string Tim13 = "GHIElectronics.TinyCLR.NativeApis.STM32F4.PwmProvider\\12";
            public const string Tim14 = "GHIElectronics.TinyCLR.NativeApis.STM32F4.PwmProvider\\13";
            public const int Channel0 = 0;
            public const int Channel1 = 1;
            public const int Channel2 = 2;
            public const int Channel3 = 3;
        }

        public static class UartPort
        {
            public const string Usart1 = "GHIElectronics.TinyCLR.NativeApis.STM32F4.UartProvider\\0";
            public const string Usart2 = "GHIElectronics.TinyCLR.NativeApis.STM32F4.UartProvider\\1";
            public const string Usart3 = "GHIElectronics.TinyCLR.NativeApis.STM32F4.UartProvider\\2";
            public const string Uart4 = "GHIElectronics.TinyCLR.NativeApis.STM32F4.UartProvider\\3";
            public const string Uart5 = "GHIElectronics.TinyCLR.NativeApis.STM32F4.UartProvider\\4";
            public const string Usart6 = "GHIElectronics.TinyCLR.NativeApis.STM32F4.UartProvider\\5";
            public const string Uart7 = "GHIElectronics.TinyCLR.NativeApis.STM32F4.UartProvider\\6";
            public const string Uart8 = "GHIElectronics.TinyCLR.NativeApis.STM32F4.UartProvider\\7";
        }

        public static class I2cBus
        {
            public const string I2c1 = "GHIElectronics.TinyCLR.NativeApis.STM32F4.I2cProvider\\0";
            public const string I2c2 = "GHIElectronics.TinyCLR.NativeApis.STM32F4.I2cProvider\\1";
            public const string I2c3 = "GHIElectronics.TinyCLR.NativeApis.STM32F4.I2cProvider\\2";
        }

        public static class SpiBus
        {
            public const string Spi1 = "GHIElectronics.TinyCLR.NativeApis.STM32F4.SpiProvider\\0";
            public const string Spi2 = "GHIElectronics.TinyCLR.NativeApis.STM32F4.SpiProvider\\1";
            public const string Spi3 = "GHIElectronics.TinyCLR.NativeApis.STM32F4.SpiProvider\\2";
            public const string Spi4 = "GHIElectronics.TinyCLR.NativeApis.STM32F4.SpiProvider\\3";
            public const string Spi5 = "GHIElectronics.TinyCLR.NativeApis.STM32F4.SpiProvider\\4";
            public const string Spi6 = "GHIElectronics.TinyCLR.NativeApis.STM32F4.SpiProvider\\5";
        }

        public static class CanBus
        {
            public const string Can1 = "GHIElectronics.TinyCLR.NativeApis.STM32F4.CanProvider\\0";
            public const string Can2 = "GHIElectronics.TinyCLR.NativeApis.STM32F4.CanProvider\\1";
        }

        public static class UsbClientPort
        {
            public const string UsbOtg = "GHIElectronics.TinyCLR.NativeApis.STM32F4.UsbClientProvider\\0";
        }

        public static class UsbHostPort
        {
            public const string UsbOtg = "GHIElectronics.TinyCLR.NativeApis.STM32F4.UsbHostProvider\\0";
        }

        public static class Display
        {
            public const string Lcd = "GHIElectronics.TinyCLR.NativeApis.STM32F4.DisplayProvider\\0";
        }
    }
    public static class Espectro32
    {
        /// <summary>GPIO pin definitions.</summary>
        public static class GpioPin
        {

            /// <summary>Debug LED definition</summary>
            public const int BoardLed = D15;


            /// <summary>SD Card Dectect definition</summary>
            public const int SdCardCS = 33;

            public const int ESPECTRO32_PHOTO_TR_ANALOG_CHANNEL = 0;

            public const int ESPECTRO32_SDAPIN = 21;
            public const int ESPECTRO32_SCLPIN = 22;

            public const int ESPECTRO32_BUTTON_A_PIN = 0;
            public const int ESPECTRO32_BUTTON_B_PIN = 4;

            public const int ESPECTRO32_RGBLED_GPIO = D27;
            public const int ESPECTRO32_RGBLED_COUNT = 1;

            public const int ESPECTRO32_TOUCH_COUNT = 3;

            /// <summary>GPIO pin.</summary>
            public const int D0 = 0;
            /// <summary>GPIO pin.</summary>
            public const int D1 = 1;
            /// <summary>GPIO pin.</summary>
            public const int D2 = 2;
            /// <summary>GPIO pin.</summary>
            public const int D3 = 3;
            /// <summary>GPIO pin.</summary>
            public const int D4 = 4;
            /// <summary>GPIO pin.</summary>
            public const int D5 = 5;
            /// <summary>GPIO pin.</summary>
            public const int D6 = 6;
            /// <summary>GPIO pin.</summary>
            public const int D7 = 7;
            /// <summary>GPIO pin.</summary>
            public const int D8 = 8;
            /// <summary>GPIO pin.</summary>
            public const int D9 = 9;
            /// <summary>GPIO pin.</summary>
            public const int D10 = 10;
            /// <summary>GPIO pin.</summary>
            public const int D11 = 11;
            /// <summary>GPIO pin.</summary>
            public const int D12 = 12;
            /// <summary>GPIO pin.</summary>
            public const int D13 = 13;
            /// <summary>GPIO pin.</summary>
            public const int D14 = 14;
            /// <summary>GPIO pin.</summary>
            public const int D15 = 15;
            /// <summary>GPIO pin.</summary>
            public const int D16 = 16;
            /// <summary>GPIO pin.</summary>
            public const int D17 = 17;
            /// <summary>GPIO pin.</summary>
            public const int D18 = 18;
            /// <summary>GPIO pin.</summary>
            public const int D19 = 19;

            /// <summary>GPIO pin.</summary>
            public const int D21 = 21;
            /// <summary>GPIO pin.</summary>
            public const int D23 = 23;
            /// <summary>GPIO pin.</summary>
            public const int D25 = 25;
            /// <summary>GPIO pin.</summary>
            public const int D26 = 26;
            /// <summary>GPIO pin.</summary>
            public const int D27 = 27;
            /// <summary>GPIO pin.</summary>
            public const int D32 = 32;
            /// <summary>GPIO pin.</summary>
            public const int D33 = 33;
            /// <summary>GPIO pin.</summary>
            public const int D34 = 34;
            /// <summary>GPIO pin.</summary>
            public const int D35 = 35;
            /// <summary>GPIO pin.</summary>
            public const int D36 = 36;
            /// <summary>GPIO pin.</summary>
            public const int D37 = 37;
            /// <summary>GPIO pin.</summary>
            public const int D38 = 38;
            /// <summary>GPIO pin.</summary>
            public const int D39 = 39;

           
        }
        public static class AdcChannel
        {

            public const int A0 = 0;
            public const int A1 = 1;
            public const int A2 = 2;
            public const int A3 = 3;
            public const int A4 = 4;
            public const int A5 = 5;
            public const int A6 = 6;
            public const int A7 = 7;
            /*
            0=36, 1=37, 2=38, 3=39, 4=32, 5=33, 6=34, 7=35
            */
        }
        
    }


}
