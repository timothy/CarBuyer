using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuyer
{

    public class Car
    {
        public int Number { get; set; }       // Corresponding number in the table
        public string Name { get; set; }
        public string Category { get; set; }
        public string NewUsed { get; set; } // New or used
        public int Price { get; set; }
        public string Country { get; set; } // US or foriegn
        public int MPG { get; set; }        // Miles per gallon
        public int Milage { get; set; }     // Odomoter reading
        public int Doors { get; set; }
        public double EngineL { get; set; }    // engine liters
        public int EngineCyl { get; set; }  // engine cylinders
        public string Hybrid { get; set; }  // Hybrid or not
        public int Year { get; set; }
        public string Chose { get; set; }   // The car chosen

        public override string ToString()
        {
            return String.Format("#{0} Name: {1} Category: {2} New/Used: {3} Price: ${4}K Country: {5} /n MPG: {6} Milage:",
                " {7}K Doors: {8} /n Engine: {9}L {10}Cyl {11} /n Year: {12} Car Chosen: {13}",
                Number, Name, Category, NewUsed, Price, Country, MPG, Milage, Doors, EngineL, EngineCyl, Hybrid, Year, Chose);
        }



        class Program
        {

            public static List<Car> car = new List<Car>()
        {
            new Car{Number= 1, Name= "Cadillac", Category= "Midsize", NewUsed= "New", Price= 31, Country= "US", MPG= 20, Milage= 0, Doors= 4, EngineL= 3.6, EngineCyl= 6, Hybrid= "Standard", Year= 2008, Chose= "Cadillac CTS"},
            new Car{Number= 2, Name= "Lincoln", Category= "Midsize", NewUsed= "New", Price= 33, Country= "US", MPG= 22, Milage= 0, Doors= 4, EngineL= 3.5, EngineCyl= 6, Hybrid= "Standard", Year= 2008, Chose= "Lincoln MKZ"},
            new Car{Number= 3, Name= "Mercedes", Category= "Sports/Convertable", NewUsed= "New", Price= 96, Country= "Foriegn", MPG= 14, Milage= 0, Doors= 2, EngineL= 5.5, EngineCyl= 8, Hybrid= "Standard", Year= 2009, Chose= "Mercedes-Benz SL-CLass"},
            new Car{Number= 4, Name= "Chevrolet", Category= "Midsize", NewUsed= "New", Price= 23, Country= "US", MPG= 25, Milage= 0, Doors= 4, EngineL= 2.4, EngineCyl= 4, Hybrid= "Hybrid", Year= 2008, Chose= "Chevrolet Malibu Hybrid"},
            new Car{Number= 5, Name= "Honda", Category= "Sub-Comp", NewUsed= "New", Price= 18, Country= "Foriegn", MPG= 29, Milage= 0, Doors= 4, EngineL= 1.8, EngineCyl= 4, Hybrid= "Standard", Year= 2008, Chose= "Honda Civic"},
            new Car{Number= 6, Name= "Toyota", Category= "Midsize", NewUsed= "New", Price= 26, Country= "Foriegn", MPG= 34, Milage= 0, Doors= 4, EngineL= 2.4, EngineCyl= 4, Hybrid= "Hybrid", Year= 2009, Chose= "Toyota Camry Hybrid"},
            new Car{Number= 7, Name= "Ford", Category= "Compact", NewUsed= "New", Price= 17, Country= "US", MPG= 28, Milage= 0, Doors= 2, EngineL= 2.0, EngineCyl= 4, Hybrid= "Standard", Year= 2008, Chose= "Ford Focus"},
            new Car{Number= 8, Name= "Honda", Category= "Sub-Comp", NewUsed= "New", Price= 21, Country= "Foreign", MPG= 29, Milage= 0, Doors= 2, EngineL= 2.0, EngineCyl= 4, Hybrid= "Standard", Year= 2008, Chose= "Honda Civic"},
            new Car{Number= 9, Name= "Honda ", Category= "Compact", NewUsed= "New", Price= 27, Country= "Foreign", MPG= 45, Milage= 0, Doors= 4, EngineL= 4.0, EngineCyl= 4, Hybrid= "Hybrid", Year= 2008, Chose= "Honda Civic Hybrid"},
            new Car{Number= 10, Name= "Hyundai", Category= "Midsize", NewUsed= "New", Price= 16, Country= "Foreign", MPG= 28, Milage= 0, Doors= 4, EngineL= 2.0, EngineCyl= 4, Hybrid= "Standard", Year= 2008, Chose= "Hyundai Elantra"},
            new Car{Number= 11, Name= "Cadillac", Category= "SUV", NewUsed= "New", Price= 56, Country= "US", MPG= 14, Milage= 0, Doors= 4, EngineL= 6.2, EngineCyl= 8, Hybrid= "Standard", Year= 2008, Chose= "Cadillac Escalade"},
            new Car{Number= 12, Name= "Toyota", Category= "SUV", NewUsed= "New", Price= 49, Country= "Foreign", MPG= 14, Milage= 0, Doors= 4, EngineL= 5.7, EngineCyl= 8, Hybrid= "Standard", Year= 2008, Chose= "Toyota Sequoia"},
            new Car{Number= 13, Name= "Mercedes", Category= "SUV", NewUsed= "New", Price= 53, Country= "Foreign", MPG= 15, Milage= 0, Doors= 4, EngineL= 5.5, EngineCyl= 8, Hybrid= "Standard", Year= 2008, Chose= "Mercedes-Benz M-Class"},
            new Car{Number= 14, Name= "Chevrolet", Category= "Sub-Comp", NewUsed= "Used", Price= 18, Country= "US", MPG= 20, Milage= 83, Doors= 2, EngineL= 0, EngineCyl= 8, Hybrid= "Standard", Year= 2000, Chose= "Chevrolet Camaro Z28 Convertable"},
            new Car{Number= 15, Name= "Mercedes", Category= "Sports/Convertable", NewUsed= "Used", Price= 20, Country= "Foreign", MPG= 24, Milage= 66, Doors= 2, EngineL= 0, EngineCyl= 4, Hybrid= "Standard", Year= 2003, Chose= "Mercedes-Benz SLK230 Convertable"},
            new Car{Number= 16, Name= "Chevrolet", Category= "Sub-Comp", NewUsed= "Used", Price= 14, Country= "US", MPG= 21, Milage= 42, Doors= 2, EngineL= 0, EngineCyl= 8, Hybrid= "Standard", Year= 2002, Chose= "Chevrolet Camaro Z28 Coupe"},
            new Car{Number= 17, Name= "Ford", Category= "Sub-Comp", NewUsed= "Used", Price= 13, Country= "US", MPG= 20, Milage= 23, Doors= 2, EngineL= 0, EngineCyl= 8, Hybrid= "Standard", Year= 2004, Chose= "Ford Mustang GT Coupe"},
            new Car{Number= 18, Name= "Honda", Category= "Midsize", NewUsed= "Used", Price= 11, Country= "Foreign", MPG= 24, Milage= 60, Doors= 2, EngineL= 0, EngineCyl= 6, Hybrid= "Standard", Year= 2003, Chose= "Honda Accord EX V6 Coupe"},
            new Car{Number= 19, Name= "Honda", Category= "Midsize", NewUsed= "Used", Price= 15, Country= "Foreign", MPG= 28, Milage= 111, Doors= 4, EngineL= 0, EngineCyl= 4, Hybrid= "Standard", Year= 2003, Chose= "Honda Accord EX Sedan"},
            new Car{Number= 20, Name= "Lincoln", Category= "Large", NewUsed= "Used", Price= 11, Country= "US", MPG= 14, Milage= 97, Doors= 4, EngineL= 0, EngineCyl= 8, Hybrid= "Standard", Year= 2002, Chose= "Lincoln Continental"},
            new Car{Number= 21, Name= "Lincoln", Category= "Large", NewUsed= "Used", Price= 13, Country= "US", MPG= 15, Milage= 45, Doors= 4, EngineL= 0, EngineCyl= 8, Hybrid= "Standard", Year= 2002, Chose= "Lincoln LS V8"},
            new Car{Number= 22, Name= "Toyota", Category= "Compact", NewUsed= "Used", Price= 16, Country= "Foreign", MPG= 24, Milage= 102, Doors= 4, EngineL= 0, EngineCyl= 6, Hybrid= "Standard", Year= 2003, Chose= "Toyota Avalon XLS"},
            new Car{Number= 23, Name= "Toyota", Category= "Compact", NewUsed= "Used", Price= 15, Country= "Foreign", MPG= 24, Milage= 66, Doors= 2, EngineL= 0, EngineCyl= 6, Hybrid= "Standard", Year= 2004, Chose= "Toyota Solara"},
            new Car{Number= 24, Name= "Toyota", Category= "SUV", NewUsed= "Used", Price= 17, Country= "Foreign", MPG= 19, Milage= 36, Doors= 4, EngineL= 0, EngineCyl= 6, Hybrid= "Standard", Year= 2004, Chose= "Toyota 4Runner SR5"},
            new Car{Number= 25, Name= "Ford ", Category= "SUV", NewUsed= "Used", Price= 11, Country= "US", MPG= 25, Milage= 29, Doors= 4, EngineL= 0, EngineCyl= 6, Hybrid= "Standard", Year= 2003, Chose= "Ford Escape XLT"},
            new Car{Number= 26, Name= "Ford ", Category= "Large", NewUsed= "Used", Price= 9, Country= "US", MPG= 20, Milage= 59, Doors= 4, EngineL= 0, EngineCyl= 8, Hybrid= "Standard", Year= 2004, Chose= "2004 Ford Crown Victoria LX"},
            new Car{Number= 27, Name= "Ford", Category= "Sub-Comp", NewUsed= "Used", Price= 17, Country= "US", MPG= 20, Milage= 51, Doors= 2, EngineL= 0, EngineCyl= 8, Hybrid= "Standard", Year= 2003, Chose= "2003 Ford Mustang GT"},
            new Car{Number= 28, Name= "Chevrolet", Category= "SUV", NewUsed= "Used", Price= 15, Country= "US", MPG= 16, Milage= 45, Doors= 2, EngineL= 0, EngineCyl= 6, Hybrid= "Standard", Year= 2004, Chose= "2004 Chevrolet Blazer"},
            new Car{Number= 29, Name= "Cadillac", Category= "SUV", NewUsed= "Used", Price= 18, Country= "US", MPG= 14, Milage= 57, Doors= 4, EngineL= 0, EngineCyl= 8, Hybrid= "Standard", Year= 2003, Chose= "2003 Cadillac Escalade AWD"},
            new Car{Number= 30, Name= "Cadillac", Category= "Large", NewUsed= "Used", Price= 10, Country= "US", MPG= 21, Milage= 65, Doors= 4, EngineL= 0, EngineCyl= 8, Hybrid= "Standard", Year= 2002, Chose= "2002 Cadillac De Ville"},
            new Car{Number= 31, Name= "Cadillac", Category= "Midsize", NewUsed= "Used", Price= 15, Country= "US", MPG= 20, Milage= 50, Doors= 2, EngineL= 0, EngineCyl= 8, Hybrid= "Standard", Year= 2001, Chose= "2001 Cadillac Eldorado ESC"},
            new Car{Number= 32, Name= "Hyundai", Category= "SUV", NewUsed= "Used", Price= 19, Country= "Foreign", MPG= 23, Milage= 40, Doors= 4, EngineL= 0, EngineCyl= 6, Hybrid= "Standard", Year= 2005, Chose= "2005 Hyundai Tucson 4x4"},
            new Car{Number= 33, Name= "Hyundai", Category= "Compact", NewUsed= "Used", Price= 7, Country= "Foreign", MPG= 28, Milage= 90, Doors= 4, EngineL= 0, EngineCyl= 4, Hybrid= "Standard", Year= 2001, Chose= "2001 Hyundai Elantra GLS Sedan"},
        };

            static void Main(string[] args)
            {
                bool used = false;

                bool Luxury = false;
                bool Standard = false;
                bool Economy = false;

                bool Excellent_mpg = false;
                bool Medium_MPG = false;
                bool Low_mpg = false;

                bool SUV = false;

                bool Cadillac = false;
                bool Lincoln = false;
                bool Mercedes = false;
                bool Ford = false;
                bool Chevrilet = false;

                bool Toyota = false;
                bool Honda = false;
                bool Hyundai = false;

                bool civic = false;
                bool focus = false;


                Car user = new Car();

                Console.WriteLine("Please enter the desired milliage of car");//Milige
                user.Milage = Convert.ToInt32(Console.ReadLine());

                if (user.Milage > 0)// New or Used  // Rule 1 and 2
                {
                    used = true;
                }

                Console.WriteLine("Please enter the desired price of car");//Price
                user.Price = Convert.ToInt32(Console.ReadLine());

                if (user.Price >= 30000)// Rule 3
                {
                    Luxury = true;
                }
                if (user.Price >= 20000)// Rule 4
                {
                    Standard = true;
                }
                if (user.Price > 5000)// Rule 5
                {
                    Economy = true;
                }

                Console.WriteLine("Please enter the desired EngineCyl of car");//EngineCyl
                user.EngineCyl = Convert.ToInt32(Console.ReadLine());

                if (user.EngineCyl == 8 && used == false)// Rule 6
                {
                    Luxury = true;
                }



                Console.WriteLine("Please enter the desired AVGCMPG of car");//MPG
                user.MPG = Convert.ToInt32(Console.ReadLine());

                if (user.MPG >= 25) // Rule 7
                {
                    Excellent_mpg = true;
                }
                else if (user.MPG > 16)
                {
                    Medium_MPG = true;
                }
                else if (user.MPG <= 16)
                {
                    Low_mpg = true;
                }


                //Rule 8
                if (Luxury == true)
                {
                    SUV = true;

                    Cadillac = true;
                    Mercedes = true;
                }

                Console.WriteLine("Please enter either \"F\" for foreign or US");//Foreign or USA
                user.Country = Console.ReadLine();

                if (user.Country == "F") // Rule 9
                {
                    Toyota = true;
                    Mercedes = true;
                    Honda = true;
                    Hyundai = true;
                }



                Console.WriteLine("Please enter the desired sive of car e.g. Large,\n Midsize, Sub-Comp, Sports/Convertable, Compact,  ");//car size
                user.Category = Console.ReadLine();//car size


                //Rule 10
                if (used == false && user.Category == "Sub-Comp")
                {
                    Honda = true;
                    civic = true;
                }

                //Rule 11
                if (used == false && user.Category == "Compact")
                {
                    Honda = true;
                    civic = true;
                    Ford = true;
                    focus = true;
                }

                if (used == false && user.Category == "Midsize" && Economy == true)// Rule 12
                {
                    Hyundai = true;
                }


                //Rule 13
                if (used == false && user.Category == "Midsize" && Standard == true)
                {
                    Toyota = true;
                    Chevrilet = true;
                }


                //Rule 14
                if (used == false && user.Category == "Midsize" && Luxury == true)
                {
                    Cadillac = true;
                    Lincoln = true;
                }


                //Rule 15
                if (used == true && user.Category == "Large")
                {
                    Lincoln = true;
                    Cadillac = true;
                    Ford = true;
                }

                // Rule 16
                if (used == true && SUV == true)
                {
                    Toyota = true;
                    Ford = true;
                    Chevrilet = true;
                    Cadillac = true;
                    Hyundai = true;

                }


                //Rule 17

                if (used == true && user.Category == "Sub-Comp")
                {
                    Chevrilet = true;
                    Ford = true;
                }

                //Rule 18
                if (used == true && user.Category == "Compact")
                {
                    Toyota = true;
                    Hyundai = true;
                }


                //Rule 19
                if (used == true && user.Category == "Midsize")
                {
                    Honda = true;
                    Cadillac = true;
                }


                //Rule 20
                if (used == true && user.Category == "Sports/Convertable" && user.Price >= 25000)
                {
                    Mercedes = true;
                    Luxury = true;
                }





                if (Cadillac == true)
                {
                    for (int i = 0; i < car.Count; i++)
                    {
                        if (car[i].Name == "Cadillac")
                        {
                            Console.WriteLine(car[i].ToString());
                        }
                    }
                }

                if (Lincoln == true)
                {
                    for (int i = 0; i < car.Count; i++)
                    {
                        if (car[i].Name == "Lincoln")
                        {
                            Console.WriteLine(car[i].ToString());
                        }
                    }
                }

                if (Mercedes == true)//
                {
                    for (int i = 0; i < car.Count; i++)
                    {
                        if (car[i].Name == "Mercedes")
                        {
                            Console.WriteLine(car[i].ToString());
                        }
                    }
                }

                if (Ford == true)//
                {
                    for (int i = 0; i < car.Count; i++)
                    {
                        if (car[i].Name == "Ford")
                        {
                            Console.WriteLine(car[i].ToString());
                        }
                    }
                }


                if (Chevrilet == true)//
                {
                    for (int i = 0; i < car.Count; i++)
                    {
                        if (car[i].Name == "Chevrilet")
                        {
                            Console.WriteLine(car[i].ToString());
                        }
                    }
                }

                if (Toyota == true)//Toyota
                {
                    for (int i = 0; i < car.Count; i++)
                    {
                        if (car[i].Name == "Toyota")
                        {
                            Console.WriteLine(car[i].ToString());
                        }
                    }
                }


                if (Honda == true)//Honda
                {
                    for (int i = 0; i < car.Count; i++)
                    {
                        if (car[i].Name == "Honda")
                        {
                            Console.WriteLine(car[i].ToString());
                        }
                    }
                }


                if (Hyundai == true)//Hyundai
                {
                    for (int i = 0; i < car.Count; i++)
                    {
                        if (car[i].Name == "Hyundai")
                        {
                            Console.WriteLine(car[i].ToString());
                        }
                    }
                }

                


            }
        }
    }
}
