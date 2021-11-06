using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zdanie
{
    class Build : Entrance
    {
        static int numberBld;
        private int numEntrance;

        public int getNumBuild()
        {
            return numberBld;
        }
        //...............................................

        public void setNumBuild(int num)
        {
            numberBld = num + 1;
        }
        //...............................................

        public void setNumInfo()
        {
            Console.WriteLine("Enter the number of entrance:");
            numEntrance = Convert.ToInt32(Console.ReadLine());
            setNumFloor();
            setNumApt();
        }
        //...............................................

        public int getNumEntrance()
        {
            return numEntrance;
        }
        //...............................................

        public int evaluation()
        {
            return (numEntrance * getNumFloor() * getNumApt());
        }
    }
    //==================================================================================================

    class Entrance : Floor
    {
        private int numFloor;
        public void setNumFloor()
        {
            Console.WriteLine("Enter the number of Floors:");
            numFloor = Convert.ToInt32(Console.ReadLine());
        }
        //...............................................

        public int getNumFloor()
        {
            return numFloor;
        }
    }
    //==================================================================================================

    class Floor
    {
        private int numApt;
        public void setNumApt()
        {
            Console.WriteLine("Enter the number of Appartaments:");
            numApt = Convert.ToInt32(Console.ReadLine());
        }
        //...............................................

        public int getNumApt()
        {
            return numApt;
        }
    }
    //==================================================================================================

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of building: ");
            int numBld = Convert.ToInt32(Console.ReadLine());
            Build bd = new Build();
            for (int i = 0; i < numBld; i++)
            {
                bd.setNumBuild(i);
                bd.setNumInfo();
                Console.WriteLine("The number of building: " + bd.getNumBuild());
                Console.WriteLine("The number of entrance: " + bd.getNumEntrance());
                Console.WriteLine("The number of floors: " + bd.getNumFloor());
                Console.WriteLine("The number of appartaments: " + bd.evaluation());
            }
        }
    }
}