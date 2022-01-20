using System;
using UnityEngine;

public class TriggeredDisabler : MonoBehaviour
{
    [SerializeField] private TriggerChannel[] channels;

    private void Start()
    {
        foreach (TriggerChannel channel in channels)
        {
            channel.OnTriggered += Disable;
        }
    }

    private void OnDestroy()
    {
        foreach (TriggerChannel channel in channels)
        {
            channel.OnTriggered -= Disable;
        }
    }

    private void Disable()
    {
        gameObject.SetActive(false);
    }
}