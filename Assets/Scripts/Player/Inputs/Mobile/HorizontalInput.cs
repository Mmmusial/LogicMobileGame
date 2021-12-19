using UnityEngine;
using UnityEngine.EventSystems;

namespace Player.Inputs.Mobile
{
    public class HorizontalInput : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        [SerializeField] private FloatVariable horizontalInput;
        [SerializeField] private bool moveRight;
        
        public void OnPointerDown(PointerEventData eventData)
        {
            horizontalInput.Value = moveRight ? 1 : -1;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            horizontalInput.Value = 0;
        }
    }
}