using System;

namespace TuplasFuntionPrograming
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = Counten();
            counter.Increment();
            counter.SubStract();
            Console.WriteLine(counter.get());
        }

        public static (Action Increment, Action SubStract, Func<int> get) Counten()
        {
            //Control variable
            int i = 0;
            //Actions
            Action Increment = () => i++;
            Action SubStract = () => i--;
            Func<int> get = () => i;
            //Data return 
            return (Increment, SubStract, get);

        }
    }
}
