using System;

namespace Devices {

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

    class Program {


        public static void UI() {

            List<MobileDevices> DevicesList = new List<MobileDevices>();

            while(true) {
                int Choice = 0;
                Console.WriteLine("Выберите действие со списком:\n 0) Закончить изменения\n 1) Добавить мобильное устройство\n 2) Добавить смартфон\n 3) Добавить электронную книгу\n 4) Напечатать список");
                Console.Write("==> ");
                Choice = Convert.ToInt32(Console.ReadLine());

                switch(Choice) {

                    case 0:
                        System.Environment.Exit(0);
                        break;
                    case 1:
                        Console.Write("Color: ");

                        string? newColor = " ";
                        if(newColor != null)
                            newColor = Console.ReadLine();

                        Console.Write("Price: ");

                        float newPrice = 0.0f;
                        newPrice = (float)Convert.ToDouble(Console.ReadLine());

                        Console.Write("Model : ");

                        string? newModel = " "; 
                        if(newModel != null)
                            newModel = Console.ReadLine();

                        MobileDevices newDev = new MobileDevices() {

                            Color = newColor,
                                  Price = newPrice,
                                  Model = newModel
                        };

                        DevicesList.Add(newDev);
                        break;

                    case 2:
                        Console.Write("Color: ");

                        newColor = " ";
                        if(newColor != null)
                            newColor = Console.ReadLine();

                        Console.Write("Model : ");

                        newModel = " "; 
                        if(newModel != null)
                            newModel = Console.ReadLine();

                        Console.Write("Price: ");

                        newPrice = 0.0f;
                        newPrice = (float)Convert.ToDouble(Console.ReadLine());

                        Console.Write("Firm: ");
                        string? newFirm = " ";
                        if (newFirm != null)
                            newFirm = Console.ReadLine();

                        Smartphone newPhone = new Smartphone() {

                            Color = newColor,
                                  Price = newPrice,
                                  Model = newModel,
                                  Firm = newFirm

                        };

                        DevicesList.Add(newPhone);
                        break;

                    case 3:
                        Console.Write("Color: ");

                        newColor = " ";
                        if(newColor != null)
                            newColor = Console.ReadLine();

                        Console.Write("Model : ");

                        newModel = " "; 
                        if(newModel != null)
                            newModel = Console.ReadLine();

                        Console.Write("Price: ");

                        newPrice = 0.0f;
                        newPrice = (float)Convert.ToDouble(Console.ReadLine());

                        Console.Write("Memory size: ");

                        int newValue = (int)Convert.ToInt32(Console.ReadLine());

                        Console.Write("Has backlight: ");
                        bool hasBlight = Convert.ToBoolean(Console.ReadLine());

                        ElectronicBook newEbook = new ElectronicBook() {

                            Color = newColor,
                                  Price = newPrice,
                                  Model = newModel,
                                  Value = newValue,
                                  hasBacklight = hasBlight

                        };

                        DevicesList.Add(newEbook);
                        break;

                    case 4:
                        foreach(MobileDevices Device in DevicesList) {
                            Device.Print();
                        }
                        break;



                    default:
                        Console.WriteLine("Wrong Input. Please try again.\n\n\n");
                        break;


                }

            }

        }

        public static void Main(string[] args) {
            
            UI();

        }

    }

}


