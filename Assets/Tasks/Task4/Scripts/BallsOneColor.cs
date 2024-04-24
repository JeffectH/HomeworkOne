using System.Collections.Generic;
using UnityEngine;

public class BallsOneColor : ConditionVictory
{
    private List<Ball> _ballsOneColor = new List<Ball>();
    private List<Ball> _ballsTwoColor = new List<Ball>();
    private List<Ball> _ballsThreeColor = new List<Ball>();

    public BallsOneColor(IEnumerable<Ball> ballsOneColor, IEnumerable<Ball> ballsTwoColor, IEnumerable<Ball> ballsThreeColor)
    {
        _ballsOneColor = new List<Ball>(ballsOneColor);
        _ballsTwoColor = new List<Ball>(ballsTwoColor);
        _ballsThreeColor = new List<Ball>(ballsThreeColor);
    }

    public override void PopBall(LayerMask layer) 
    {
        base.PopBall(layer);
        UpdateListBalls(CurrentBall);
    }

    public override void UpdateListBalls(Ball ball)
    {
        if (_ballsOneColor.Contains(ball)) 
        {
            _ballsOneColor.Remove(ball);

            if (_ballsOneColor.Count == 0) 
            {
                Debug.Log("Победа!");
            }
        }

        if (_ballsTwoColor.Contains(ball))
        {
            _ballsTwoColor.Remove(ball);
            if (_ballsTwoColor.Count == 0)
            {
                Debug.Log("Победа!");
            }
        }

        if (_ballsThreeColor.Contains(ball))
        {
            _ballsThreeColor.Remove(ball);
            if (_ballsThreeColor.Count == 0)
            {
                Debug.Log("Победа!");
            }
        }
    }
}
