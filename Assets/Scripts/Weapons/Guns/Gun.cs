using UnityEngine;

public class Gun : Weapon
{
    [SerializeField] private Camera _fpsCam;
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private float _damage = 10f;
    [SerializeField] private float _range = 100f;

    private const string ButtonFire = "Fire1";
    private const string ButtonReload = "Fire2";

    private void Update()
    {
        if (Input.GetButtonDown(ButtonFire)) 
            Fire();

        if (Input.GetButtonDown(ButtonReload))
            Reload();
    }

    public override void Fire()
    {
        RaycastHit hit;

        if(Physics.Raycast(_fpsCam.transform.position, _fpsCam.transform.forward, out hit, _range))
        {
            InitDamage(hit);

            InitBullet(hit);
        }
    }

    private void InitDamage(RaycastHit hit)
    {
        IDamageable damageable = hit.transform.GetComponent<IDamageable>();

        if (damageable != null)
            damageable.TakeDamage(_damage);
    }

    private void InitBullet(RaycastHit hit) => Instantiate(_bulletPrefab, hit.point, Quaternion.identity);

    public override void Reload()
    {

    }
}
