
using AdapterDesignPattern.RemoveDependencyExample.Adapter;
using ExternalLibrary;

namespace AdapterDesignPattern.RemoveDependencyExample
{
    class SdkConsumer
    {
        //private readonly ISdkClientAdapter _sdkClientAdapter;

        //public SdkConsumer(ISdkClientAdapter sdkClientAdapter)
        //{
        //    _sdkClientAdapter = sdkClientAdapter;
        //}

        public void ConsumeSdkAndDoWebRequest()
        {
            SomeSdkClient sdkClass = new SomeSdkClient();
            sdkClass.DoSomeWebRequest();
           //_sdkClientAdapter.DoSomeWebRequest();
            //Logic to be tested as part of unit test

        }
    }
}
