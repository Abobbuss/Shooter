using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _bulletLifeTime = 2f;

    private void OnEnable()
    {
        DestroyBullet();
    }

    IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(_bulletLifeTime);

        Destroy(gameObject);
    }
}
