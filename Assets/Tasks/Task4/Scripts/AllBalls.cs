using System.Collections.Generic;
using UnityEngine;

public class AllBalls : ConditionVictory
{
    private List<Ball> _balls = new List<Ball>();

    public AllBalls(IEnumerable<Ball> balls)
    {
        _balls = new List<Ball>(balls);
    }

    public override void PopBall(LayerMask layer)
    {
        base.PopBall(layer);
        UpdateListBalls(CurrentBall);
    }

    public override void UpdateListBalls(Ball ball)
    {
        _balls.Remove(ball);

        if(_balls.Count == 0) 
        {
            Debug.Log("Победа!");
        }
    }
}
