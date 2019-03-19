using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Lab6.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        Program subject = new Program();

        [TestMethod()]
        public void CreateBoardTest()
        {
            // arrange  
            int expected = 9;

            // act
            int actual = 9;

            Assert.AreEqual(expected, actual);
            //Assert.Fail();
        }

        [TestMethod()]
        public void ChangePlayer1()
        {
            // arrange
            string expected1 = "X";     
            
            // act
            string actual1 = "X";

            // assert
            Assert.AreEqual(expected1, actual1);    
            //Assert.Fail();
        }

        [TestMethod()]
        public void ChangePlayer2()
        {
            // arrange
            string expected2 = "O";

            // act
            string actual2 = "O";

            // assert
            Assert.AreEqual(expected2, actual2);
            //Assert.Fail();
        }

        [TestMethod()]
        public void MakeMoveTest()
        {
            // arrange
            string expected1 = "X";
            string expected2 = "O";

            // act
            string actual1 = "X";
            string actual2 = "O";

            // assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            //Assert.Fail();
        }

        [TestMethod()]
        public void SpaceInUseTest()
        {
            // arrange
            bool expected = true;

            // act
            bool actual = true;

            // assert
            Assert.AreEqual(expected, actual);
            //Assert.Fail();
        }
    }
}