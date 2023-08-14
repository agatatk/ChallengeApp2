namespace ChallengeApp2.tests
{
    public class EmployeeTests
    {

        [Test]
        public void WhenUserCollectTwoScoresShouldCorrectSumAsResult()
        {
            // arrange
            var employee = new Employee("Agata", "Badach", 40);
            employee.AddScore(1);
            employee.AddScore(9);
            employee.AddScore(6);
            employee.AddScore(-4);
            employee.AddScore(3);

            //act 
            int result = employee.Result;

            // assert
            Assert.AreEqual(15, result);
        }
    }
}