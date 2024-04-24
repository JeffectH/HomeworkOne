using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField, Range(0, 50)] private int _value;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IBuyer bayer))
        {
            AddCoin(bayer);
        }
    }

    private void AddCoin(IBuyer bayer) => bayer.AddCoin(_value);
}
