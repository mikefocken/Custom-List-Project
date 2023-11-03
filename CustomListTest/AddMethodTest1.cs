using CustomList;
using System.Security.Cryptography.X509Certificates;

namespace CustomListTest
{
    [TestClass]
    public class AddMethodTest1
    {
        [TestMethod]                      //SecondItemAtIndexOne
        public void AddMethod_AddTwoItems_FirstItemAtIndexZero()
        {
            // Arrange
            CustomList<string> myList = new CustomList<string>();

            myList.Add("Hello");
            myList.Add("world");
            // Assert
            Assert.AreEqual("world", myList[1]);/////passed
        }

        //public void AddMethod_AddTwoItems_FirstItemAtIndexZero()
        //{
        //    Arrange
        //    CustomList<string> myList = new CustomList<string>();

        //    myList.Add("Hello");
        //    myList.Add("world");

        //    Assert
        //    Assert.AreEqual("Hello", myList[0]);
        //}

    }
}


