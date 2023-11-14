public interface IScoresManager
{
  void AddScore(int newScore);
  List<int> GetScores();
}

public class ScoresManager : IScoresManager
{
  private List<int> scores = new List<int>();
  public List<int> GetScores()
  {
    return scores.Order().ToList();
  }
  public void AddScore(int newScore)
  {
    scores.Add(newScore);
  }
}