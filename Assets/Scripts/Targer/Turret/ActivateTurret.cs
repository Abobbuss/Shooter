using System;
using UnityEngine;
using UnityEngine.Events;

public class ActivateTurret : MonoBehaviour
{
    public event UnityAction PlayerEntered;
    public event UnityAction PlayerExited;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player _))
            PlayerEntered?.Invoke();    
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out Player _))
            PlayerExited?.Invoke();
    }
}
