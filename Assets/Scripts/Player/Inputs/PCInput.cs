using UnityEngine;

namespace Player.Inputs
{
    public class PCInput : MonoBehaviour
    {
        [SerializeField] private FloatVariable horizontalInput;
        [SerializeField] private TriggerChannel jumpInput;
        [SerializeField] private bool allowConstantJump;
        [SerializeField] private bool shouldInvert;
        [SerializeField] private float modifier;

#if UNITY_EDITOR
        private void Update()
        {
            horizontalInput.Value = shouldInvert
                ? -Input.GetAxis("Horizontal") + modifier
                : Input.GetAxis("Horizontal") - modifier;

            if (allowConstantJump || Input.GetKeyDown(KeyCode.Space))
            {
                jumpInput.Trigger();
            }
        }
    
#endif
    }
}