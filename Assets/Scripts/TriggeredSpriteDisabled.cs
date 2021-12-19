using System;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class TriggeredSpriteDisabled : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.IsPlayer())
        {
            GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}