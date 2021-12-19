using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    [SerializeField] private TriggerChannel closeChannel;
    [SerializeField] private TriggerChannel openChannel;
    [SerializeField] private bool openByDefault;
    [SerializeField] private string levelName;

    private bool _isOpen;

    private void Awake()
    {
        _isOpen = openByDefault;
    }

    private void Start()
    {
        closeChannel.OnTriggered += Close;
        openChannel.OnTriggered += Open;
    }

    private void OnDestroy()
    {
        closeChannel.OnTriggered -= Close;
        openChannel.OnTriggered -= Open;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.IsPlayer() && _isOpen)
        {
            SceneManager.LoadScene(levelName);
        }   
    }

    private void Open()
    {
        _isOpen = true;
    }

    private void Close()
    {
        _isOpen = false;
    }
}