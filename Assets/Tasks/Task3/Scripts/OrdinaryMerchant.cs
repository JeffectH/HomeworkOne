using UnityEngine;

public class OrdinaryMerchant : Merchant
{
    protected override void SellProduct(IBuyer wallet) => Debug.Log("Я тебе ничего не продам!");
}
