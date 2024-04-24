using UnityEngine;

public class WinConditionSetup : MonoBehaviour
{
    private ConditionVictory _conditionVictory;

    public void SetConditionVictory(ConditionVictory conditionVictory)
    {
        _conditionVictory = conditionVictory;
    }

    public void PopBall(LayerMask layer) 
    {
        _conditionVictory?.PopBall(layer);
    }
}
