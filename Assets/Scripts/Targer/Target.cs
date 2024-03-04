using UnityEngine;

public class Target : MonoBehaviour, IDamageable
{
    [SerializeField] private float _health = 50f;

    public void TakeDamage(float damage)
    {
        if (_health > 0)
        {
            _health -= damage;

            if (_health <= 0)
                Die();
        }
    }

    private void Die() => Destroy(gameObject);
}
