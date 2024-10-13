using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lab1.Tests {

    public class MobileDevicesTests {

        [Theory]
        [InlineData(null, null, 0)] 
            [InlineData("ABC", "GREEN", 10000000)] 
                public virtual void Print_Should_NotCrashProgram(string Model, String Color, int Price) {

                    Console.WriteLine(String.Format(" Model: {0}\n Color: {1}\n Price: {2}",
                                Model, Color, Price));
                }

    }

    public class ProgramUITests {

        [Fact]
        public static void UI_Should_NotCrashProgram() {
            for (int Choice = -100000; Choice < 100000; ++Choice) {

                switch(Choice) {

                    case 0:
                        break;
                    case 1:
                        Console.Write("Color: ");

                        Console.Write("Price: ");

                        Console.Write("Model : ");


                        break;

                    case 2:
                        Console.Write("Color: ");

                        Console.Write("Model : ");

                        Console.Write("Price: ");

                        Console.Write("Firm: ");

                        break;

                    case 3:
                        Console.Write("Color: ");

                        Console.Write("Model : ");

                        Console.Write("Price: ");

                        Console.Write("Memory size: ");

                        Console.Write("Has backlight: ");

                        break;

                    case 4:
                        Console.WriteLine("List Written");
                        break;


                    default:
                        Console.WriteLine("Wrong Input. Please try again.\n\n\n");
                        break;

                }

            }

        }

    }

}


