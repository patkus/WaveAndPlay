namespace WaveAndPlay.Web.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }

        public Player(int id, string nickname, string firstName, string lastName)
        {
            Id = id;
            Nickname = nickname;
            FirstName = firstName;
            LastName = lastName;
            FullName = $"{firstName} {lastName}";
        }
    }
}
