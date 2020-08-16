using System;
using System.Collections.Generic;
using System.Text;

namespace ExternalLibrary
{
    public class Target
    {
        private readonly IExpectedInterface _expectedInterface;

        public Target(IExpectedInterface expectedInterface)
        {
            _expectedInterface = expectedInterface;
        }

        public void DoSomethingWithExpectedInterface()
        {
            _expectedInterface.SomeMethod();
        }
    }

    public interface IExpectedInterface
    {
        void SomeMethod();
    }
}
