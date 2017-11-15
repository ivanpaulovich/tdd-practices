using Xunit;

namespace FxPro.Tests
{
    public class DataTests
    {
        public DataTests()
        {

        }

        [Fact]
        public void Enqueue_Valid_String()
        {
            //Arrange
            IGenericQueue<string> sut = new Queue<string>(100);

            string newItem = "FxPro Test";

            //Act
            sut.Enqueue(newItem);

            string actual = sut.Dequeue();

            //Assert
            Assert.Equal(newItem, actual);
        }

        [Fact]
        public void Enqueue_When_Full_Should_Throws_Ex()
        {
            //Arrange
            IGenericQueue<string> sut = new Queue<string>(0);

            string newItem = "FxPro Test";

            try
            {
                //Act
                sut.Enqueue(newItem);

                //Assert
                Assert.True(false, "Didnt throws exception");
            }
            catch (QueueIsFullException)
            {
                //Assert
                Assert.True(true);
            }

        }

        [Fact]
        public void Dequeue_When_Empty_Should_Throws_Ex()
        {
            //Arrange
            IGenericQueue<string> sut = new Queue<string>(0);

            try
            {
                //Act
                string actual = sut.Dequeue();

                //Assert
                Assert.True(false, "Didnt throws exception");
            }
            catch (QueueIsEmptyException)
            {
                //Assert
                Assert.True(true);
            }

        }
    }
}
