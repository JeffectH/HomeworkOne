using UnityEngine;

public abstract class Merchant : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out IBuyer wallet)) 
        {
            SellProduct(wallet);
        }
    }

    protected abstract void SellProduct(IBuyer wallet);
}
