namespace PlayerManager1
{
    public class Player
    {
        private string Name {get;}
        private int Score {get; set;}

        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetScore()
        {
            return Score;
        }
    }
}