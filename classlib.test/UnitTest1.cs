using classlib1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace classlib.test {

    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestMethod1 () {
            // Arrange
            var o = new Class1();
            var expected = "OK";
            // Act
            var actual = o.Go ();
            // Assert
            Assert.AreEqual (expected,actual);
        }
    }
}
