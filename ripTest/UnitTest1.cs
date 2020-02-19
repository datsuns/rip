using NUnit.Framework;


namespace ripTest
{
    public class Tests
    {
        private rip.Volume sut;
        [SetUp]
        public void Setup()
        {
            this.sut = new rip.Volume();
        }

        [Test]
        public void Test1()
        {
            sut.Mute();
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            sut.Unmute();
            Assert.Pass();
        }
    }
}