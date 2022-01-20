using System;
using Player.Inputs;
using UnityEngine;

public class RedLightReset : MonoBehaviour
{
    [SerializeField] private FloatVariable horizontalInput;
    [SerializeField] private TriggerChannel jumpInput;
    [SerializeField] private TriggerChannel resetChannel;
    [SerializeField] private BoolVariable redLightOn;
    [SerializeField] private float inputThreshold;
    [SerializeField] private float toggleInterval;
    
    private void Start()
    {
        InvokeRepeating(nameof(Toggle), 0f, toggleInterval);
        jumpInput.OnTriggered += Lose;
    }

    private void OnDestroy()
    {
        jumpInput.OnTriggered -= Lose;
    }

    private void Update()
    {
        if (Mathf.Abs(horizontalInput.Value) >= inputThreshold)
        {
            Lose();
        }
    }

    private void Lose()
    {
        if (redLightOn.Value)
        {
            resetChannel.Trigger();
        }
    }

    private void Toggle()
    {
        redLightOn.Value = !redLightOn.Value;
    }
}