using UnityEngine;

public class CameraTarget : MonoBehaviour
{
    private Transform _cameraTransform;

    private void Start()
    {
        if (Camera.main != null)
        {
            _cameraTransform = Camera.main.transform;
        }
    }

    private void Update()
    {
        _cameraTransform.position =
            new Vector3(transform.position.x, transform.position.y, _cameraTransform.position.z);
    }
}