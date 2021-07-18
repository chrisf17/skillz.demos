using System;

namespace interfaces
{
    interface IAccelerable
    {
        int Speed{get;}
        int MaxSpeed{get; set;}
        void Accelerate(int a);
        //TODO 1: Uncomment line below. Build an notice compiler doesn't
        //        complain about Car not implementing the Boost() method.
        //        This is because there is a default implementation defined.
        //void Boost()=>Accelerate(20);
    }
    class Car: IAccelerable
    {
        public int Speed{get; set;}
        public int MaxSpeed{get; set;}
        public void Accelerate(int a)
        {
            Speed += a;
        }
        //TODO 4: Implement a Boost() method on Car
        //        Uncomment the line below.
        //        Notice the types implementation will apply
        // public void Boost()
        // {
        //     Speed += 15;
        // }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //TODO 3: Change the Car reference to an IAccelerable Interface reference
            //        IAccelerable c = new Car();
            //        Notice the compile error goes away.
            Car c = new Car();
            //TODO 2: Uncomment Line below and build. A compile error will result
            //        Types don't inherit the default implementation 
            //        and have to provide their own concrete implementation
            //c.Boost();
            Console.WriteLine(c.Speed);
        }
    }
}
