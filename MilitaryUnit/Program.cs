using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MilitaryUnit_Library;
using MilitaryUnit_Library.ParachuteDataFolder;
using MilitaryUnit_Library.PersonnelFolder;
using MilitaryUnit_Library.TransportationFolder;


namespace MilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            //personnel Data
            Personnel personnel = new Personnel();
            Corporate corporate = new Corporate();
            Managment managment = new Managment();
            LowerEnlisted lowerEnlisted = new LowerEnlisted();


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Airborne Ops Data\n");

            Thread.Sleep(1000);
            personnel.NumberOfPersonnel(150);
            corporate.NumberOfPersonnel(15);
            managment.NumberOfPersonnel(45);
            lowerEnlisted.NumberOfPersonnel(90);

            Console.ReadKey();
            Console.Clear();


            //Transportation data
            Transportation transportation = new Transportation();
            Aircraft aircraft = new Aircraft();
            Vehicles vehicles = new Vehicles();

            Thread.Sleep(1000);
            transportation.NumberOfTrans(12);
            aircraft.NumberOfTrans(4);
            aircraft.NumberOfAirCrafts(2, "C-130");
            aircraft.NumberOfAirCrafts(2, "C-17");

            Thread.Sleep(1000);

            vehicles.NumberOfTrans(8);
            vehicles.NumberOfVehicles(3, "HMMVVs");
            vehicles.NumberOfVehicles(5,"LMTVs"); 

            Console.ReadKey();
            Console.Clear();

            //parachute data
            Parachutes parachutes = new Parachutes();
            PersonnelParachutes peopleChutes = new PersonnelParachutes();
            Cargo cargo = new Cargo();

            parachutes.TotalNumberOfParachutes(6000);

            peopleChutes.TotalNumberOfParachutes(5500);
            peopleChutes.PeopleParachutes(1200, "T-10s");
            peopleChutes.PeopleParachutes(1150, "T-11M");
            peopleChutes.PeopleParachutes(3150,"T-11R");

            Thread.Sleep(1000);

            cargo.TotalNumberOfParachutes(500);
            cargo.HeavyRigParachutes(125, "G-11B");
            cargo.HeavyRigParachutes(135, "G-12");
            cargo.HeavyRigParachutes(240, "G-14");

            Console.ReadKey();
        }
    }
}
