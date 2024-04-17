using System;

namespace GameUnits
{
    public class SettlerUnit : Unit 
    {
        public SettlerUnit() : base(2) 
        {
            Cost = 5;
        }

        public override float Cost { get { return 5; } }

        public override void Move() 
        {
            Console.WriteLine("SettlerUnit moved 1 space.");
        }
    }
}