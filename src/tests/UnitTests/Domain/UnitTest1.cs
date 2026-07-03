using Domain;

namespace UnitTests.Domain
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Should_Create_Product_When_Data_Is_Valid()
        {
            var produt = new Product("TV", "T100", "USD");

            if (produt != null)
                Assert.Pass();

            Assert.Fail();
        }

        [Test]
        public void Should_Throw_When_Name_Is_Empty()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var produt = new Product("", "T100", "");
            });
        }

        [Test]
        public void Should_Throw_When_SKU_Is_Empty()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var produt = new Product("TV", "", "USD");
            });
        }

        [Test]
        public void Should_Throw_When_Currency_Is_Empty()
        {

            Assert.Throws<ArgumentException>(() =>
            {
                var produt = new Product("TV", "T100", "");
            });
        }
    }
}
