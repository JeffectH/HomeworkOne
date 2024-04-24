using UnityEngine;

public abstract class Gunshot
{
    protected GameObject PrefabBullet;
    protected Vector3 PointShot;
    protected Vector3 Direction;
    protected int ForceShot;

    public abstract void Shot();
}
