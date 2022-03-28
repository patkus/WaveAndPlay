namespace WaveAndPlay.Web.Models
{
    public class TeamPlayer
    {
        public Player Player { get; set; }
        public Team Team { get; set; } 

        public TeamPlayer(Player player, Team team)
        {
            Player = player;
            Team = team;
        }
    }
}
