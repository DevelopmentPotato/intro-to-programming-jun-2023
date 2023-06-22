using Games.Exceptions;

namespace Games
{
    public abstract class Game
    {
        private readonly List<Player> _players = new();

        public void AddPlayer(string name, int score)
        {
            if (_players.Any(p => p.getName() == name))
            {
                throw new PlayerAlreadyAddedToGameException();
            }
            else
            {
                if (score > 300 || score < 0)
                {
                    throw new ScoreNotPossibleException();
                }
                else
                {
                    _players.Add(new Player(name, score));

                }

            }
        }

        public double AverageScore()
        {
            var val = _players.Average(p => p.getScore());
            return val;
        }

        public abstract List<List<Player>> DetermineVictors();

        public Player GetPlayerByName(string name)
        {
            return _players.First(p => p.getName() == name);
        }

        public int GetPlayerCount()
        {
            if (_players.Count < 1)
            {
                throw new NotEnoughPlayersException();
            }
            else
            {
                return _players.Count;
            }
        }
    }
}