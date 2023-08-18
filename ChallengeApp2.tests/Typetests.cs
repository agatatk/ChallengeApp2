namespace ChallengeApp2.tests
{
    public class Typetests
    {
        [Test]
        public void CheckingIfNumbersAreNotEqual()
        {
            //arrange
            int number1 = 6;
            int number2 = 9;

            //act

            //assert
            Assert.AreNotEqual(number1, number2);
        }

        [Test] 
        public void CheckingIfFloatingNumbersAreNotEqual() 
        {
            //arrange
            float number3  = 33;
            float number4 = 55;

            //act
            var floatsum = number3 + number4;   
            //assert
            Assert.AreNotEqual(number3, number4);
        }


        [Test]
        public void CheckingIfTypeReferenceStringsAreEqual()
        {
            //arrange
            var user1 = GetUser("Tomasz");
            var user2 = GetUser("Tomasz");
            //act

            //assert
            Assert.AreEqual(user1.Login, user2.Login);
        }
        private User GetUser(string name)
        {
            return new User(name);
        }

        [Test]

        public void CheckingIfStringsAreNotEqual() 
        {
            //arrange
            string user1 = "Kasia";
            string user2 = "Basia";

            //act

            //assert
            Assert.AreNotEqual(user1, user2);
        }
    }
}
