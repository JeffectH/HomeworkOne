using UnityEngine;

public class FruitMerchant : Merchant
{
    [SerializeField] private int _minRepute;
    [SerializeField] private int _cost;

    protected override void SellProduct(IBuyer buyer)
    {
        if (buyer.Repute >= _minRepute) 
        {
            Debug.Log("� ���������� ��������� ������!");

            if (buyer.Coins >= _cost)
            {
                Debug.Log("��������� �� ������� ������� :)");
            }
            else 
            {
                Debug.Log("� ��� ������������ �����!");
            }
        }
        else
        {
            Debug.Log("��������� ���� �������!");
        }
    }
}
