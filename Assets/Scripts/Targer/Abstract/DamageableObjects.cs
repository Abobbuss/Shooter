using UnityEngine;

public abstract class DamageableObjects : MonoBehaviour, IDamageable
{
    protected float Health;

    public virtual void TakeDamage(float damage) => Health -= damage;
}
