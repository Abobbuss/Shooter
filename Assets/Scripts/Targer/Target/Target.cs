using UnityEngine;

public class Target : DamageableObjects
{
    [SerializeField] private float _startHealth = 50f;

    private void Start()
    {
        Health = _startHealth;
    }

    public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage);

        if (Health <= 0)
            Die();
    }

    private void Die() => Destroy(gameObject);
}
