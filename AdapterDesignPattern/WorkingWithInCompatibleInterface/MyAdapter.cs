using System;
using System.Collections.Generic;
using System.Text;
using ExternalLibrary;

namespace AdapterDesignPattern.WorkingWithInCompatibleInterface
{
    class MyAdapter : IExpectedInterface
    {
        public void SomeMethod()
        {
            //My own logic
            MyAdaptee myAdaptee=new MyAdaptee();
            myAdaptee.SomeLogicToPassToTarget();
            Console.WriteLine("Hello from myAdapter class");
        }
    }
}
