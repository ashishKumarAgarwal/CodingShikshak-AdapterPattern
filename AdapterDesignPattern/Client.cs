using AdapterDesignPattern.RemoveDependencyExample;
using AdapterDesignPattern.RemoveDependencyExample.Adapter;
using AdapterDesignPattern.WorkingWithInCompatibleInterface;
using ExternalLibrary;
using Microsoft.Extensions.DependencyInjection;

namespace AdapterDesignPattern
{
    internal class Client
    {
        private static void Main(string[] args)
        {
            #region Remove Dependency Example

            //Without Wrapper class
            SdkConsumer consumer = new SdkConsumer();
            consumer.ConsumeSdkAndDoWebRequest();

            //With Wrapper class
            //var services = new ServiceCollection();
            //services.AddTransient<ISdkClientAdapter, SdkClientAdapter>();
            //services.AddTransient<SdkConsumer>();

            //var serviceProvider = services.BuildServiceProvider();
            //var sdkConsumer = serviceProvider.GetService<SdkConsumer>();
            //sdkConsumer.ConsumeSdkAndDoWebRequest();

            #endregion Remove Dependency Example

            #region WorkingWithInCompatibleInterface

            //services.AddTransient<IExpectedInterface, MyAdapter>();
            //services.AddTransient<Target>();
            //var serviceProvider2 = services.BuildServiceProvider();
            //var target = serviceProvider2.GetService<Target>();
            //target.DoSomethingWithExpectedInterface();
            #endregion
        }
    }
}