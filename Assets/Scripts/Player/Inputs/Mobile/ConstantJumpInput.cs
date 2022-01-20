using System;
using UnityEngine;

namespace Player.Inputs.Mobile
{
    public class ConstantJumpInput : MonoBehaviour
    {
        [SerializeField] private TriggerChannel jumpChannel;

        private const float Interval = 0.5f;
        
        private void Start()
        {
            InvokeRepeating(nameof(Trigger), Interval, Interval);
        }

        private void Trigger()
        {
            jumpChannel.Trigger();
        }
    }
}