using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_console.example.eventDelegate
{

    public class Car
    {
        // Internal state data.
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }

        // Is the car alive or dead?
        private bool carIsDead;

        public delegate void CarEngineHandler(string msgForCaller);

        // 2) Define a member variable of this delegate.
        private CarEngineHandler listOfHandlers;

        // Using event handler
        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;

        // Remove registration function for the caller
        public void UnRegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            listOfHandlers -= methodToCall;
        }
        
        // 3) Add registration function for the caller.
        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            // Code dibawah ini tidak berjalan semestinya
            //if (listOfHandlers == null)
            //    listOfHandlers = methodToCall;
            //else
            //    Delegate.Combine(listOfHandlers, methodToCall);

            // Pengganti menggunakan multicasting delegate
            listOfHandlers += methodToCall;
        }

        // 4) Implement the Accelerate() method to invoke the delegate's
        // invocation list under the correct circumstances.
        public void Accelerate(int delta)
        {
            // If this car is "dead," send dead message.
            if (carIsDead)
            {
                if (listOfHandlers != null)
                    listOfHandlers("Sorry, this car is dead...");
            }
            else
            {
                CurrentSpeed += delta;
                // Is this car "almost dead"?
                if (10 == (MaxSpeed - CurrentSpeed) && listOfHandlers != null)
                {
                    listOfHandlers("Careful buddy! Gonna blow!");
                    if (CurrentSpeed >= MaxSpeed)
                        carIsDead = true;
                    else
                        Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
                }
            }
        }

        // Class constructors.
        public Car() { MaxSpeed = 100; }
        public Car(string name, int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }

        // Investigasi delegate
        public static void DisplayDelegateInfo(Delegate delObj)
        {
            // Print the names of each member in the
            // delegate's invocation list.
            foreach (Delegate d in delObj.GetInvocationList())
            {
                Console.WriteLine("Method Name: {0}", d.Method);
                Console.WriteLine("Type Name: {0}", d.Target);
            }
        }

    }

    public class Car2
    {
        // Internal state data.
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }

        // Is the car alive or dead?
        private bool carIsDead;

        public delegate void CarEngineHandler(string msgForCaller);

        // 2) Define a member variable of this delegate.
        private CarEngineHandler listOfHandlers;

        // Using event handler
        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;

        // Remove registration function for the caller
        public void UnRegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            listOfHandlers -= methodToCall;
        }

        // 3) Add registration function for the caller.
        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            // Code dibawah ini tidak berjalan semestinya
            //if (listOfHandlers == null)
            //    listOfHandlers = methodToCall;
            //else
            //    Delegate.Combine(listOfHandlers, methodToCall);

            // Pengganti menggunakan multicasting delegate
            listOfHandlers += methodToCall;
        }

        // 4) Implement the Accelerate() method to invoke the delegate's
        // invocation list under the correct circumstances.
        public void Accelerate(int delta)
        {
            // If the car is dead, fire Exploded event.
            if (carIsDead)
            {
                if (Exploded != null)
                    Exploded("Sorry, this car is dead...");
            }
            else
            {
                CurrentSpeed += delta;
                // Almost dead?
                if (10 == MaxSpeed - CurrentSpeed
                && AboutToBlow != null)
                {
                    AboutToBlow("Careful buddy! Gonna blow!");
                }
                // Still OK!
                if (CurrentSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
            }
        }

        // Class constructors.
        public Car2() { MaxSpeed = 100; }
        public Car2(string name, int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }

    }

    class Example_multicasting_delegate2
    {
        public Example_multicasting_delegate2()
        {
            Console.WriteLine("***** Delegates as event enablers *****\n");
            // First, make a Car object.
            Car2 c1 = new Car2("SlugBug", 100, 10);
            // Versi lain registrasi handler
            // Register event handlers.
            c1.AboutToBlow += new Car2.CarEngineHandler(CarIsAlmostDoomed);
            c1.AboutToBlow += new Car2.CarEngineHandler(CarAboutToBlow);
            Car2.CarEngineHandler d = new Car2.CarEngineHandler(CarExploded);
            c1.Exploded += d;
            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);
            // Remove CarExploded method
            // from invocation list.
            c1.Exploded -= d;
            Console.WriteLine("\n***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);
            Console.ReadLine();
        }


        public static void CarAboutToBlow(string msg)
        { Console.WriteLine(msg); }

        public static void CarIsAlmostDoomed(string msg)
        { Console.WriteLine("=> Critical Message from Car: {0}", msg); }

        public static void CarExploded(string msg)
        { Console.WriteLine(msg); }
    }

    class Example_multicasting_delegate
    {
        public Example_multicasting_delegate()
        {
            Console.WriteLine("***** Delegates as event enablers *****\n");
            // First, make a Car object.
            Car c1 = new Car("SlugBug", 100, 10);
            // Now, tell the car which method to call
            // when it wants to send us messages.   
            Car.CarEngineHandler handler1 = new Car.CarEngineHandler(OnCarEngineEvent1);
            Car.CarEngineHandler handler2 = new Car.CarEngineHandler(OnCarEngineEvent2);

            c1.RegisterWithCarEngine(handler1);
            c1.RegisterWithCarEngine(handler2);
            // Remove handler1
            c1.UnRegisterWithCarEngine(handler1);
            // Speed up (this will trigger the events).
            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            Console.WriteLine("\nAfter remove handler");
            // Remove handler1
            //c1.UnRegisterWithCarEngine(handler2);

            // review
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            Console.ReadLine();
        }
        // This is the target for incoming events.
        public static void OnCarEngineEvent1(string msg)
        {
            Console.WriteLine("\n***** Message From Car Object *****");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("***********************************\n");
        }

        public static void OnCarEngineEvent2(string msg)
        {
            Console.WriteLine("\n***** Message Next Event *****");
            Console.WriteLine("=> UPPERCASE : {0}", msg.ToUpper());
            Console.WriteLine("***********************************\n");
        }

    }
}
