using ExternalLibrary;

namespace AdapterDesignPattern.RemoveDependencyExample.Adapter
{
    internal class SdkClientAdapter : ISdkClientAdapter
    {
        public void DoSomeWebRequest()
        {
            SomeSdkClient client = new SomeSdkClient();
            client.DoSomeWebRequest();
        }
    }
}