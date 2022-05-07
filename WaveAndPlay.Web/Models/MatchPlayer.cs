namespace WaveAndPlay.Web.Models
{
    public class MatchPlayer
    {
        public Match Match { get; set; }
        public Player Player { get; set; }
        public MatchPlayer(Match match, Player player)
        {
            Match = match;
            Player = player;
        }
    }
}
