using UnityEngine;

public class Example : MonoBehaviour
{
    [SerializeField] private Weapon _weapon;

    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Transform _pointShot;
    [SerializeField] private int _forceShot;
    [SerializeField] private int _numberRounds;
    [SerializeField] private int _numberRoundsPerShot;

    private void Awake()
    {
        _weapon.SetGunShot(new SingleShotWeapon(_bulletPrefab, _pointShot.position, _pointShot.transform.forward, _forceShot, _numberRounds));
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log($"Стреляем по одной. Колличество патронов:{_numberRounds}");
            _weapon.SetGunShot(new SingleShotWeapon(_bulletPrefab, _pointShot.position, _pointShot.transform.forward, _forceShot, _numberRounds));
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log($"Стреляем по одной. Колличество патронов неограниченно!");
            _weapon.SetGunShot(new InfiniteAmmoWeapon(_bulletPrefab, _pointShot.position, _pointShot.transform.forward, _forceShot));
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log($"Стреляем по три. Колличество патронов:{_numberRounds}");
            _weapon.SetGunShot(new MultishotWeapon(_bulletPrefab, _pointShot.position, _pointShot.transform.forward, _forceShot, _numberRoundsPerShot, _numberRounds));
        }

        if (Input.GetMouseButtonDown(0)) 
        {
            _weapon?.Shot();
        }
    }
}
