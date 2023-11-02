using CustomList;
using System.Security.Cryptography.X509Certificates;

namespace CustomListTest
{
    [TestClass]
    public class AddMethodTest1
    {
        [TestMethod]
        //public void AddMethod_AddTwoItems_SecondItemAtIndexOne()
        //{
        //      // Arrange
        //    CustomList<string> myList = new CustomList<string>();

        //    myList.Add("Hello");
        //    myList.Add("world");



        //    //Assert
        //    Assert.AreEqual("world", myList[1]);


        public void AddMethod_AddTwoItems_FirstItemAtIndexZero()
        { 
            // Arrange
            CustomList<string> myList = new CustomList<string>();

            myList.Add("Hello");
            myList.Add("world");
            myList.Add("How");
            myList.Add("are");
            myList.Add("doing");
            myList.Add("today?");

            //Assert
            Assert.AreEqual("Hello", myList[0]);
        }

       //    public void AddMethod_CountItemsAsItemsAreAdd()
                //
                //    CustomList<string> myList = new CustomList<string>();
                //    // arrange

                //    myList.Add("Hello");
                //    myList.Add("world");
                //    myList.Add("How");
                //    myList.Add("are you?");

                //    ///act
                //    for (int i = 0; i > value.length; i++)
                //    {
                //        value.lenght=count;
                            
                //    }


    }         //    ///Assert
            //    Assert.AreEqual(count,myList[1]);
    
}