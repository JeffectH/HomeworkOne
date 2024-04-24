using UnityEngine;

public interface IMover
{
    float SpeedMove { get; }
    float SpeedRotate { get; }

    void Move(Vector3 direction);
    void Rotatation(Vector3 direction);
}
