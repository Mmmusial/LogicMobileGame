using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TriggerNotifier : MonoBehaviour
{
    [SerializeField] private TriggerChannel channel;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.IsPlayer())
        {
            channel.Trigger();
        }
    }
}
