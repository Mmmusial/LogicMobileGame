using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace DefaultNamespace
{
    public class ClickDoorOpener : MonoBehaviour
    {
        [SerializeField] private TriggerChannel openChannel;
        [SerializeField] private int requiredClickCount;

        private int _clickCount;
        private Camera _camera;

        private void Awake()
        {
            _camera = Camera.main;
        }

        private void Update()
        {
            if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
            {
                CastOn(Input.touches[0].position);
            }

            if (Input.GetMouseButtonDown(0))
            {
                CastOn(Input.mousePosition);
            }
        }

        private void CastOn(Vector2 screenPoint)
        {
            RaycastHit2D hit = Physics2D.Raycast(_camera.ScreenToWorldPoint(screenPoint), Vector2.zero);
            
            if (hit.transform == transform && ++_clickCount >= requiredClickCount)
            {
                openChannel.Trigger();
            }
        }
    }
}