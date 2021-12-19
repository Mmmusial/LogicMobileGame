using System;
using UnityEngine;

public class DelayedTriggerNotifier : MonoBehaviour
{
    [SerializeField] private TriggerChannel resetChannel;
    [SerializeField] private float triggerDelay;

    private void Start()
    {
        Invoke(nameof(Trigger), triggerDelay);
    }

    private void Trigger()
    {
        resetChannel.Trigger();
    }
}