using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cinema;


namespace CinemaTestProject
{

    [TestClass]
    public class CinemaTest
    {
        [TestMethod]
        public void Adult_before_5pm_Test()
        {
            //Arrange
            int quantity = 2;
            string person = "adult";
            string day = "true";
            int time = 0400;
            double expected = 29.0;

            //Act
            CinemaDetails Cin1 = new CinemaDetails();
            Cin1.Adult_before_5pm(quantity, person, day, time);

            //Assert 
            double total_price = quantity * Cin1.adult_before_5_price;
            Assert.AreEqual(expected, total_price, 14.5, "Passed");

        }

        [TestMethod]
        public void Adult_after_5pm_Test()
        {
            //Arrange
            int quantity = 2;
            string person = "adult";
            string day = "true";
            int time = 0600;
            double expected = 35.0;

            //Act
            CinemaDetails Cin1 = new CinemaDetails();
            Cin1.Adult_after_5pm(quantity, person, day, time);

            //Assert 
            double total_price = quantity * Cin1.adult_after_5_price;
            Assert.AreEqual(expected, total_price, 17.5, "Passed");

        }

        [TestMethod]
        public void Adult_tuesday_Test()
        {
            //Arrange
            int quantity = 3;
            string person = "adult";
            string day = "Tuesday";
            double expected = 39;

            //Act
            CinemaDetails Cin1 = new CinemaDetails();
            Cin1.Adult_tuesday(quantity, person, day);

            //Assert
            double total_price = quantity * Cin1.adult_tuesday_price;
            Assert.AreEqual(expected, total_price, 13, "Passed");


        }

        [TestMethod]
        public void Child_Test()
        {
            //Arrange
            int quantity = 4;
            string person = "child";
            double expected = 48;

            //Act
            CinemaDetails cin1 = new CinemaDetails();
            cin1.Child_price(quantity, person);

            //Assert
            double total_price = quantity * cin1.child_price;
            Assert.AreEqual(expected, total_price, 12, "Passed");

        }


        [TestMethod]
        public void Senior_Test()
        {
            //Arrange
            int quantity = 2;
            string person = "senior";
            double expected = 25;

            //Act
            CinemaDetails cin1 = new CinemaDetails();
            cin1.Senior_price(quantity, person);
            //Assert
            double total_price = quantity * cin1.senior_price;
            Assert.AreEqual(expected, total_price, 12.5,"passed");

        }

        [TestMethod]
        public void Student_Test()
        {
            //Arrange
            int quantity = 3;
            string person = "student";
            double expected = 42;

            //Act
            CinemaDetails cin1 = new CinemaDetails();
            cin1.Student_price(quantity, person);

            //Assert
            double total_price = quantity * cin1.student_price;
            Assert.AreEqual(expected, total_price, 14,"passed");

        }

        [TestMethod]
        public void Family_test()
        {
            //Arrange
            int quantity = 2;
            string person = "family";
            double expected = 92;

            //Act
            CinemaDetails Cin1 = new CinemaDetails();
            Cin1.Family_price(quantity, person);

            //Assert 
            double total_price = quantity * Cin1.family_price;
            Assert.AreEqual(expected, total_price, 92, "Passed");

        }

        [TestMethod]
        public void Chick_flick_thursdays_test()
        {
            //Arrange
            int quantity = 2;
            string person = "Chick";
            string day = "Thursdays";
            double expected = 43;

            //Act
            CinemaDetails Cin1 = new CinemaDetails();
            Cin1.Chick_flick_thursdays_price(quantity, person, day);

            //Assert 
            double total_price = quantity * Cin1.chick_flick_thursdays_price;
            Assert.AreEqual(expected, total_price, 43, "Passed");

        }

        [TestMethod]
        public void Kids_and_carers()
        {
            //Arrange
            int quantity = 2;
            string person = "Kids and carers";
            string day = "Wedndesday";
            double expected = 24;

            //Act
            CinemaDetails Cin1 = new CinemaDetails();
            Cin1.Kids_and_carers_price(quantity, person, day);

            //Assert 
            double total_price = quantity * Cin1.kids_and_carers_price;
            Assert.AreEqual(expected, total_price, 25, "Passed");

        }
    }
}