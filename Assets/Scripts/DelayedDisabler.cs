using System;
using UnityEngine;

public class DelayedDisabler : MonoBehaviour
{
    [SerializeField] private float delay;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.IsPlayer())
        {
            Invoke(nameof(Disable), delay);
        }
    }

    private void Disable()
    {
        gameObject.SetActive(false);
    }
}