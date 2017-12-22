using Animals;
using NUnit.Framework;

namespace AnimalSpecs
{
    // Testing .NET Core with NUnit in Visual Studio 2017
    // http://www.alteridem.net/2017/05/04/test-net-core-nunit-vs2017/
    //
    // NUnit
    // https://www.nuget.org/packages/NUnit/
    // Install-Package NUnit -Version 3.9.0
    //
    // NUnit3TestAdapter
    // https://www.nuget.org/packages/NUnit3TestAdapter/
    // Install-Package NUnit3TestAdapter -Version 3.9.0
    //
    // Microsoft.NET.Test.Sdk
    // https://www.nuget.org/packages/Microsoft.NET.Test.Sdk/15.6.0-preview-20171211-02
    // Install-Package Microsoft.NET.Test.Sdk -Version 15.6.0-preview-20171211-02
    [TestFixture]
    public class When_telling_a_dog_to_bark
    {
        [Test]
        public void The_dog_barks_once_for_1_treat()
        {
            var dog = new Dog();
            var response = dog.Bark(1);
            Assert.AreEqual(1, response.Count);
        }

        [Test]
        public void The_dog_doesnt_bark_for_no_treat()
        {
            var dog = new Dog();
            var response = dog.Bark(0);
            Assert.AreEqual(0, response.Count);
        }
    }
}
