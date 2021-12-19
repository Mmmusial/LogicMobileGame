using UnityEngine;

namespace Player.Inputs.Mobile
{
    public class ConstantJumpInput : MonoBehaviour
    {
        [SerializeField] private TriggerChannel jumpChannel;

        private void Update()
        {
            jumpChannel.Trigger();
        }
    }
}