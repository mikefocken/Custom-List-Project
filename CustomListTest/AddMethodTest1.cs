using CustomList;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace CustomListTest
{
    [TestClass]
    public class AddMethodTest1
    {
        [TestMethod]
        //public void AddMethod_AddTwoItems_SecondItemAtIndexOne()
        //{
        //    // Arrange
        //    CustomList<string> myList = new CustomList<string>();

        //    myList.Add("Hello");
        //    myList.Add("World");
        //    // Assert
        //    Assert.AreEqual("World", myList[1]);/////passed
        //}

        //public void AddMethod_AddTwoItems_FirstItemAtIndexZero()
        //{
        //    //Arrange
        //    CustomList<string> myList = new CustomList<string>();

        //    myList.Add("Hello");
        //    myList.Add("World");
        //    myList.Add("How");
        //    myList.Add("are");
        //    myList.Add("doing");
        //    myList.Add("today?");

            //Assert
            //Assert.AreEqual("Hello", myList[0]);///passed
        //}
        public void AddMethod_CountIncreasesAsItemsAdded()
        {
            //arrange
            
            CustomList<string> myList = new CustomList<string>();
            //Act
            myList.Add("Hello");
            myList.Add("World");
            myList.Add("How");
            myList.Add("are");
            myList.Add("doing");
            myList.Add("today?");
            //Assert
            //Assert.AreEqual(4,4);passed
            
            for (int i = 4; i > myList.Capacity; i++)
            {
                string[] newMyList;
            }





        }



    }
}


