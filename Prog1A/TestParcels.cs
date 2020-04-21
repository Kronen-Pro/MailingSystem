// Program 1A
// CIS 200-01
// Fall 2019
// Due: 9/23/2019
// By: Andrew L. Wright (students use Grading ID)

// File: TestParcels.cs
// This is a simple, console application designed to exercise the Parcel hierarchy.
// It creates several different Parcels and prints them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Prog1
{
    class TestParcels
    {
        // Precondition:  None
        // Postcondition: Parcels have been created and displayed
        static void Main(string[] args)
        {
            // Test Data - Magic Numbers OK
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4

            Letter letter1 = new Letter(a1, a2, 3.95M);                            // Letter test object
            GroundPackage gp1 = new GroundPackage(a3, a4, 14, 10, 5, 12.5);        // Ground test object
            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15,    // Next Day test object
                85, 7.50M);
            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a4, a1, 46.5, 39.5, 28.0, // Two Day test object
                80.5, TwoDayAirPackage.Delivery.Saver);

            Letter letter2 = new Letter(a3, a2, 4.00M);
            Letter letter3 = new Letter(a3, a4, 5.00M);
            Letter letter4 = new Letter(a4, a1, 6.00M);

            TwoDayAirPackage days = new TwoDayAirPackage(a1, a2, 50, 66, 75, 80, TwoDayAirPackage.Delivery.Saver);

            NextDayAirPackage next = new NextDayAirPackage(a4, a3, 100, 45, 20, 55, 45);

            GroundPackage hola = new GroundPackage(a2, a1, 100, 100, 20, 345);


            List<Parcel> parcels;      // List of test parcels

            parcels = new List<Parcel>(); // List of Parcel objects for sorting
            parcels.Add(letter2);
            parcels.Add(letter3);
            parcels.Add(letter4);
            parcels.Add(letter1); 
            parcels.Add(gp1);
            parcels.Add(ndap1);
            parcels.Add(tdap1);
            parcels.Add(days);
            parcels.Add(next);
            parcels.Add(hola);

            WriteLine("Original List:"); // Outputing 
            WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                WriteLine(p);
                WriteLine("====================");
            }

            Console.ReadLine(); // After  pressing enter button, the data will be sorted by cost in ascending order
            Pause(); // After ENTER List of Parcels will be shown before sort and in Ascending Order

            Console.WriteLine("Before Sorting:"); // Outputing costs without sorting 
            Console.WriteLine("===============");
            foreach (Parcel g in parcels)
                Console.WriteLine(g.CalcCost());

            Console.WriteLine();

            parcels.Sort(); // Ascending Sort order
            Console.WriteLine("Ascending List By Cost:");
            Console.WriteLine("=======================");
            foreach (Parcel z in parcels)
                Console.WriteLine(z.CalcCost());

            Console.ReadLine(); // Press Enter to proceed to the next sorting 
            Pause();

            Console.WriteLine("Before Sorting"); // Destination Zip before sorting 
            Console.WriteLine("==============");
            foreach (Parcel g in parcels)
                Console.WriteLine(g.DestinationAddress.Zip);

            Console.WriteLine();

            parcels.Sort(new Descending_Order()); // Descending order by destination zip
            Console.WriteLine("Descending Order By Destination Zip:");
            Console.WriteLine("====================================");
            foreach (Parcel z in parcels)
                Console.WriteLine(z.DestinationAddress.Zip);

            Console.ReadLine(); // Press Enter to proceed to the next sorting
            Pause();

            Console.WriteLine("Before Sorting");
            Console.WriteLine("==============");
            foreach (Parcel g in parcels)
            {
                Console.WriteLine(g);
                Console.WriteLine("====================");
            }

            Console.WriteLine(); // Space between sorts 

            parcels.Sort(new Extra_Credit()); // Extra Credit Sort 
            Console.WriteLine("Extra Credit Sorting");
            Console.WriteLine("====================");
            foreach (Parcel z in parcels)
                Console.WriteLine(z);





        }

        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        public static void Pause()
        {
            WriteLine("Press Enter to Continue...");
            ReadLine();

            Console.Clear(); // Clear screen
        }

        




    }
}
