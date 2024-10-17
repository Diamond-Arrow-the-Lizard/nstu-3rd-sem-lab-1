using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Lab1.Tests {

    public class MobileDevices {

        public string? Model {set; get; } = "";
        public string? Color {set; get; } = "";
        public float Price {set; get; }

        public virtual void Print() {

            Console.WriteLine(String.Format(" Model: {0}\n Color: {1}\n Price: {2}",
                        Model, Color, Price));
        }

    }

    public class Smartphone : MobileDevices {

        public string? Firm {set; get; } = "";
        public override void Print() {

            Console.WriteLine(String.Format(" Model: {0}\n Firm: {1}\n Color: {2}\n Price: {3}",
                        Model, Firm, Color, Price));
        }

    }

    public class ElectronicBook : MobileDevices {

        public int Value {set; get; }

        public bool hasBacklight = false;

        public override void Print() {

            Console.WriteLine(String.Format(" Model: {0}\n Value: {1}\n Color: {2}\n Price: {3}\n Has Backlight: {4}",
                        Model, Value, Color, Price, hasBacklight));
        }

    }

    public class MobileDevicesTests {

        [Theory]
        [InlineData(null, null, 0)] 
            [InlineData("ABC", "GREEN", 10000000)] 
                public virtual void Print_Should_NotCrashProgram(string Model, string Color, int Price) {

                    Console.WriteLine(String.Format(" Model: {0}\n Color: {1}\n Price: {2}",
                                Model, Color, Price));
                }

    }

    public class ProgramUITests {
            
        [Theory]
        [InlineData("", "", (float)-1*Int32.MaxValue)]
        [InlineData(null, null, (float)Int32.MaxValue)]
        [InlineData("\n", "\n", 0.0)]
        public void Create_MobileDevice_Should_Succeed(string? newModel, string? newColor, float newPrice) {
            
            var newDevice = new MobileDevices() {
                Model = newModel,
                Color = newColor,
                Price = newPrice
            };

            return; 
        }

        [Theory]
        [InlineData("", "", (float)-1*Int32.MaxValue, "")]
        [InlineData(null, null, (float)Int32.MaxValue, null)]
        [InlineData("\n", "\n", 0.0, "\n")]
        public void Create_Smartphone_Should_Succeed(string? newModel, string? newColor, float newPrice, string? newFirm) {
            
            var newPhone = new Smartphone() {
                Model = newModel,
                Color = newColor,
                Price = newPrice,
                Firm = newFirm
            };

            return; 
        }

        [Theory]
        [InlineData("", "", (float)-1*Int32.MaxValue, -1*Int32.MaxValue, false)]
        [InlineData(null, null, (float)Int32.MaxValue, Int32.MaxValue, true)]
        [InlineData("\n", "\n", 0.0, 0, false)]
        public void Create_Ebook_Should_Succeed(string? newModel, string? newColor, float newPrice, int newValue, bool newBacklight) {
            
            var newEbook = new ElectronicBook() {
                Model = newModel,
                Color = newColor,
                Price = newPrice,
                Value = newValue,
                hasBacklight = newBacklight
            };

            return; 
        }

    }

}


