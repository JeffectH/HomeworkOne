using UnityEngine;

public class SingleShotWeapon : Gunshot
{
    private int _numberRounds;

    public SingleShotWeapon(GameObject prefabBullet, Vector3 pointShot, Vector3 direction, int forceShot, int numberRounds)
    {
        PrefabBullet = prefabBullet;
        PointShot = pointShot;
        Direction = direction;
        ForceShot = forceShot;
        _numberRounds = numberRounds;
    }

    public override void Shot()
    {
        if (_numberRounds > 0)
        {
            GameObject newBullet = Object.Instantiate(PrefabBullet, PointShot, Quaternion.identity);

            newBullet.GetComponent<Rigidbody>()?.AddForce(Direction * ForceShot, ForceMode.Force);

            _numberRounds--;
        }
        else
        {
            Debug.Log("Обойма пуста!");
        }
    }
}
