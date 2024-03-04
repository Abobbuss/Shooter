using UnityEngine;

public abstract class Weapon : MonoBehaviour, IWeapon
{
    public abstract void Fire();

    public abstract void Reload();
}
