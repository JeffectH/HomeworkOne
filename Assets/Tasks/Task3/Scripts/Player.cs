using System;
using UnityEngine;

public class Player : MonoBehaviour, IBuyer, IMover
{
    [SerializeField, Range(0,200)] private float _speedMove;
    [SerializeField, Range(0, 500)] private float _speedRotate;

    public int Coins { get; private set; }

    public int Repute { get; private set; }

    public float SpeedMove { get; private set; }

    public float SpeedRotate { get; private set; }

    private void Awake()
    {
        Inisialize();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
            Move(Vector3.forward);

        if (Input.GetKey(KeyCode.S))
            Move(Vector3.back);

        if (Input.GetKey(KeyCode.A))
            Rotatation(Vector3.down);

        if (Input.GetKey(KeyCode.D))
            Rotatation(Vector3.up);
    }

    public void Inisialize()
    {
        SpeedMove = _speedMove;
        SpeedRotate = _speedRotate;
    }

    public void AddCoin(int value)
    {
        if (value < 0)
            throw new ArgumentOutOfRangeException(nameof(value));

        Coins += value;
        Debug.Log(Coins);
    }

    public void RemoveCoin(int value)
    {
        if (value < 0)
            throw new ArgumentOutOfRangeException(nameof(value));

        Coins -= value;
        Debug.Log(Coins);
    }

    public void AddRepute(int value)
    {
        if (value < 0)
            throw new ArgumentOutOfRangeException(nameof(value));

        Repute += value;
        Debug.Log(Repute);
    }

    public void Move(Vector3 direction)
    {
        transform.Translate(direction * SpeedMove * Time.deltaTime);
    }

    public void Rotatation(Vector3 direction)
    {
        transform.Rotate(direction * SpeedRotate * Time.deltaTime);
    }
}
