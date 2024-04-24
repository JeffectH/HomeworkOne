using UnityEngine;

public class Reputation : MonoBehaviour
{
    [SerializeField, Range(0, 100)] private int _value;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IBuyer bayer))
        {
            AddReputation(bayer);
        }
    }

    private void AddReputation(IBuyer bayer) => bayer.AddRepute(_value);
}
