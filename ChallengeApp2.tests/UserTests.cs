namespace ChallengeApp2.tests
{
    public class Tests
    {

        [Test]
        public void WhenUserCollectTwoScores_ShouldCorrectSumAsResult()
        {
            // arrange
            var user = new User("Agata");
            user.AddScore(5);
            user.AddScore(8);

            //act 
            int result = user.Result;

            // assert
            Assert.AreEqual(13, result);
        } 
    }
}