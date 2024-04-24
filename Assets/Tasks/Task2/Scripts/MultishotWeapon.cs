using UnityEngine;

public class MultishotWeapon : Gunshot
{
    private int _numberRounds;
    private int _numberRoundsPerShot;
    private float _offset = -0.4f;

    public MultishotWeapon(GameObject prefabBullet, Vector3 pointShot, Vector3 direction, int forceShot, int numberRoundsPerShot, int numberRounds)
    {
        PrefabBullet = prefabBullet;
        PointShot = pointShot;
        Direction = direction;
        ForceShot = forceShot;
        _numberRoundsPerShot = numberRoundsPerShot;
        _numberRounds = numberRounds;
    }

    public override void Shot()
    {
        float offset = _offset; ;

        if (_numberRounds >= _numberRoundsPerShot)
        {
            for (int i = 0; i < _numberRoundsPerShot; i++)
            {
                GameObject newBullet = Object.Instantiate(PrefabBullet, new Vector3(PointShot.x, PointShot.y, PointShot.z + offset), Quaternion.identity);

                newBullet.GetComponent<Rigidbody>()?.AddForce(Direction * ForceShot, ForceMode.Force);

                _numberRounds -= _numberRoundsPerShot;

                offset += Mathf.Abs(_offset);
            }
        }
        else
        {
            Debug.Log("Обойма пуста!");
        }
    }
}
