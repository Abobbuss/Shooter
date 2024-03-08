using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Turret : DamageableObjects
{
    [SerializeField] private ActivateTurret _activateTurret;
    [SerializeField] private float _startHealth = 40f;

    private bool _active;

    private void Start()
    {
        Health = _startHealth;
    }

    private void Update()
    {

    }

    public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage);

        if (damage <= 0)
            Die();
    }

    private void Die() => Destroy(gameObject);

    private void OnEnable()
    {
        _activateTurret.PlayerEntered += Activate; ;
        _activateTurret.PlayerExited += Deactivate;
    }

    private void OnDisable()
    {
        _activateTurret.PlayerEntered -= Activate; ;
        _activateTurret.PlayerExited -= Deactivate;
    }

    private void Activate() => _active = true;

    private void Deactivate() => _active = false;
}
