using UnityEngine;
using UnityEngine.EventSystems;

namespace Player.Inputs.Mobile
{
    public class WindInput : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        [SerializeField] private FloatVariable horizontalInput;
        [SerializeField] private float windPower;
        [SerializeField] private bool moveRight;
        
        public void OnPointerDown(PointerEventData eventData)
        {
            horizontalInput.Value = moveRight ? 1 - windPower : -1 + windPower;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            horizontalInput.Value = -windPower;
        }
    }
}