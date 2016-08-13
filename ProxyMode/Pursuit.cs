using System;

namespace ProxyMode
{
    public class Pursuit : IGiveGift
    {
        private readonly SchoolGirl _girl;

        public Pursuit(SchoolGirl girl)
        {
            _girl = girl;
        }
        public void GiveDolls()
        {
            Console.WriteLine(_girl.Name + " gives you dolls.");
        }

        public void GiveFlowers()
        {
            Console.WriteLine(_girl.Name + " gives you flowers.");
        }

        public void GiveCholocate()
        {
            Console.WriteLine(_girl.Name + " gives you cholocate.");
        }
    }
}