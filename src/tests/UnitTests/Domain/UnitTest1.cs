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
            try
            {
                var produt = new Product("", "T100", "USD");
            }
            catch (Exception ex)
            {
                if (ex is ArgumentException)
                    Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void Should_Throw_When_SKU_Is_Empty()
        {
            try
            {
                var produt = new Product("TV", "", "USD");
            }
            catch (Exception ex)
            {
                if (ex is ArgumentException)
                    Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void Should_Throw_When_Currency_Is_Empty()
        {
            try
            {
                var produt = new Product("TV", "", "");
            }
            catch (Exception ex)
            {
                if (ex is ArgumentException)
                    Assert.Pass();
            }

            Assert.Fail();
        }
    }
}
