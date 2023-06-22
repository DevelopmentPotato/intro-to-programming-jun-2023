namespace Games;

public class Player
{
    private string _name;
    private int _score;

    public Player(string name, int score)
    {
        _name = name;
        _score = score;
    }

    public int getScore() { return _score; }
    public string getName() { return _name;  }

    public void setScore(int score) { _score = score; }
    public void setName(string name) { _name = name; }
}