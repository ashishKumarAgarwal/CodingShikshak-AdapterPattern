using System;

namespace AdapterDesignPattern.WorkingWithInCompatibleInterface
{
    internal class MyAdaptee
    {
        public void SomeLogicToPassToTarget()
        {
            //Some Logic
            Console.WriteLine("Hello from My Adaptee");
        }
    }
}