using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_console.example.eventDelegate
{
    class Car3
    {
        // Internal state data.
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }
        public delegate void CarEngineHandler(object sender, EventArgsClass e);
        public event EventHandler<EventArgsClass> Exploded;
        public event EventHandler<EventArgsClass> AboutToBlow;
        // Is the car alive or dead?
        private bool carIsDead;

        public void Accelerate(int delta)
        {
            // If the car is dead, fire Exploded event.
            if (carIsDead)
            {
                if (Exploded != null)
                    Exploded(this, new EventArgsClass("Sorry, this car is dead..."));
            } 
            else
            {
                    CurrentSpeed += delta;
                    // Almost dead?
                    if (10 == MaxSpeed - CurrentSpeed
                    && AboutToBlow != null)
                    {
                        AboutToBlow(this, new EventArgsClass("Blow danger.."));
                    }
                    // Still OK!
                    if (CurrentSpeed >= MaxSpeed)
                        carIsDead = true;
                    else
                        Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
            }

        }

        // Class constructors.
        public Car3() { MaxSpeed = 100; }
        public Car3(string name, int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }
    }
    class EventArgsClass : EventArgs
    {
        public readonly string msg;
        public EventArgsClass(string Msg)
        {
            this.msg = Msg;
        }
    }

    class ExampleArgsClass
    {
        public ExampleArgsClass()
        {
            Console.WriteLine("***** Prim and Proper Events *****\n");
            // Make a car as usual.
            Car3 c1 = new Car3("SlugBug", 100, 10);
            // Register event handlers.
            c1.AboutToBlow += CarIsAlmostDoomed;
            c1.AboutToBlow += CarAboutToBlow;

            // Menggunakan anonymouse method
            c1.AboutToBlow += delegate
            {
                Console.WriteLine("Method dari anonymous class");
            };

            // Menggunakan anonymouse method
            c1.AboutToBlow += delegate(object sender, EventArgsClass e)
            {
                Console.WriteLine("Method anonymous with parameters");
            };

            // Menggunakan event handler
            EventHandler<EventArgsClass> d = new EventHandler<EventArgsClass>(CarExploded);
            c1.Exploded += d;
            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);
        }

        public static void CarIsAlmostDoomed(object sender, EventArgsClass e)
        {
            Console.WriteLine("{0} says: {1}", sender, e.msg);
        }

        public static void CarAboutToBlow(object sender, EventArgsClass e)
        {
            Console.WriteLine("{0} says: {1}", sender, e.msg);
        }

        public static void CarExploded(object sender, EventArgsClass e)
        {
            Console.WriteLine("{0} exploded: {1}", sender, e.msg);
        }
    }
}
