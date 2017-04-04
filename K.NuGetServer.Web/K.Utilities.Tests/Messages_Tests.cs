
namespace K.Utilities.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using Utilities;

    [TestClass]
    public class Messages_Tests
    {
        private Mock<Messages> mockMessages;

        [TestInitialize]
        public void Initialize()
        {
            mockMessages = new Mock<Messages>();
        }

        [TestMethod]
        public void ToString_Test()
        {
            var expected = nameof(ToString_Test);
            mockMessages.Setup(m => m.GetTestMessage()).Returns(expected);

            var actual = mockMessages.Object.GetTestMessage();

            Assert.AreEqual(expected, actual);
        }
    }
}