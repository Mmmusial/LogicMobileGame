using System;
using Player.Inputs;
using UnityEngine;

public class RedLightReset : MonoBehaviour
{
    [SerializeField] private FloatVariable horizontalInput;
    [SerializeField] private TriggerChannel resetChannel;
    [SerializeField] private BoolVariable redLightOn;
    [SerializeField] private float inputThreshold;
    [SerializeField] private float toggleInterval;
    
    private void Start()
    {
        InvokeRepeating(nameof(Toggle), 0f, toggleInterval);
    }

    private void Update()
    {
        if (redLightOn.Value && Mathf.Abs(horizontalInput.Value) >= inputThreshold)
        {
            resetChannel.Trigger();
        }
    }

    private void Toggle()
    {
        redLightOn.Value = !redLightOn.Value;
    }
}