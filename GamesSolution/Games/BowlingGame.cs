using Games.Exceptions;

namespace Games
{
    public class BowlingGame : Game
    {
        List<Player> _players = new();
        public BowlingGame()
        {
            
        }

        public override List<List<Player>> DetermineVictors()
        {
            if(_players.Count < 2 )
            {
                throw new NotEnoughPlayersException();
            }
            else
            {
                List<Player> victors = _players.Where(p => p.getScore() == _players.Max(pl => pl.getScore())).ToList();
                List<Player> losers = _players.Where(p => p.getScore() == _players.Min(pl => pl.getScore())).ToList();
                List<List<Player>> sol = new();
                sol.Add(victors);
                sol.Add(losers);
                return sol;
            }
            
        }
    }
}