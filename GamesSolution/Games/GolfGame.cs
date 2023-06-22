using Games.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games;

public class GolfGame : Game
{
    private readonly List<Player> _players = new List<Player>();
    public GolfGame()
    {
        
    }
    public override List<List<Player>> DetermineVictors()
    {
        if (_players.Count < 2)
        {
            throw new NotEnoughPlayersException();
        }
        else
        {
            List<Player> victors = _players.Where(p => p.getScore() == _players.Min(pl => pl.getScore())).ToList();
            List<Player> losers = _players.Where(p => p.getScore() == _players.Max(pl => pl.getScore())).ToList();
            List<List<Player>> sol = new();
            sol.Add(victors);
            sol.Add(losers);
            return sol;
        }

    }
}
