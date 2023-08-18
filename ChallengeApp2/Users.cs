namespace ChallengeApp2
{
    public class User
    {
        private List<int> score = new List<int>();
        public User(string name)
        {
            this.Name = name;
        }
        public User(string login, string password, string name)
        {
            this.Login = login;
            this.Password = password;
            this.Name = name;  
        }

        public string Login { get; private set; }

        public string Password { get; private set; }

        public string Name { get; private set; }    

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }
        public void AddScore(int score)
        {
            this.score.Add(score);
        }
    }
}