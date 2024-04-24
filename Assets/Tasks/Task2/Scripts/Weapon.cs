using UnityEngine;

public class Weapon : MonoBehaviour
{
    private Gunshot _gunshot;

    public void SetGunShot(Gunshot gunshot)
    {
        _gunshot = gunshot;
    }

    public void Shot()
    {
        _gunshot.Shot();
    }
}
