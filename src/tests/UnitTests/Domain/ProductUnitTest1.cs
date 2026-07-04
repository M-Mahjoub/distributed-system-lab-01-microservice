using Domain;

namespace UnitTests.Domain
{
    public class ProductUnitTest1
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Should_Create_Product_When_Data_Is_Valid()
        {
            var produt = new Product("TV", "T100", "USD", 100);

            if (produt != null)
                Assert.Pass();

            Assert.Fail();
        }

        [Test]
        public void Should_Throw_When_Name_Is_Empty()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var produt = new Product("", "T100", "USD", 10);
            });
        }

        [Test]
        public void Should_Throw_When_SKU_Is_Empty()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var produt = new Product("TV", "", "USD", 10);
            });
        }

        [Test]
        public void Should_Throw_When_Currency_Is_Empty()
        {

            Assert.Throws<ArgumentException>(() =>
            {
                var produt = new Product("TV", "T100", null, 10);
            });
        }

        [Test]
        public void Should_Create_Money_When_Data_Is_Valid()
        {

            var produt = new Product("TV", "T100", "USD", 100);

            if (produt.Money != null)
                Assert.Pass();

            Assert.Fail();
        }

        [Test]
        public void Should_Throw_When_Amount_Is_Negative()
        {

            Assert.Throws<ArgumentException>(() =>
            {
                var produt = new Product("TV", "T100", "USD", -10);
            });
        }

        [Test]
        public void Should_Be_Equal_When_Amount_And_Currency_Are_Equal()
        {

            var produt = new Product("TV", "T100", "USD", 10);
            var produt2 = new Product("TV", "T100", "USD", 10);

            if (produt.Equals(produt2))
                Assert.Pass();

            Assert.Fail();
        }

        [Test]
        public void Should_Not_Be_Equal_When_Currency_Is_Different()
        {

            var produt = new Product("TV", "T100", "USD", 10);
            var produt2 = new Product("TV", "T100", "PHP", 10);

            if (!produt.Equals(produt2))
                Assert.Pass();

            Assert.Fail();
        }
    }
}
