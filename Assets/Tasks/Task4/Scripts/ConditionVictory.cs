using UnityEngine;

public abstract class ConditionVictory 
{
    protected Ball CurrentBall;

    public abstract void UpdateListBalls(Ball ball);

    public virtual void PopBall(LayerMask layer) 
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, layer))
        {
            if (hit.collider.TryGetComponent(out Ball ball))
            {
                CurrentBall = ball;

                ball.TakeDamaga();
            }
        }
    }
}
