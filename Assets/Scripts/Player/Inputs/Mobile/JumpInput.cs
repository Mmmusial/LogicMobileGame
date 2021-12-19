using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Player.Inputs.Mobile
{
    public class JumpInput : MonoBehaviour, IPointerDownHandler
    {
        [SerializeField] private TriggerChannel jumpChannel;

        public void OnPointerDown(PointerEventData eventData)
        {
            jumpChannel.Trigger();
        }
    }
}