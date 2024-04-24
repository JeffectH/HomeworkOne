using UnityEngine;

public class ArmorMerchant : Merchant
{
    [SerializeField] private int _minRepute;
    [SerializeField] private int _cost;

    protected override void SellProduct(IBuyer buyer)
    {
        if (buyer.Repute >= _minRepute)
        {
            Debug.Log("О здравствуй уважаемый путник!");

            if (buyer.Coins >= _cost)
            {
                Debug.Log("Благодарю за покупку хорошей брони! :)");
            }
            else
            {
                Debug.Log("У вас недостаточно денег!");
            }
        }
        else
        {
            Debug.Log("Репутацию надо поднять!");
        }
    }
}