using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class InfiniteAmmoWeapon : Gunshot
{
    public InfiniteAmmoWeapon(GameObject prefabBullet, Vector3 pointShot, Vector3 direction, int forceShot)
    {
        PrefabBullet = prefabBullet;
        PointShot = pointShot;
        Direction = direction;
        ForceShot = forceShot;
    }

    public override void Shot()
    {
        GameObject newBullet = Object.Instantiate(PrefabBullet, PointShot, Quaternion.identity);

        newBullet.GetComponent<Rigidbody>()?.AddForce(Direction * ForceShot, ForceMode.Force);
    }
}
