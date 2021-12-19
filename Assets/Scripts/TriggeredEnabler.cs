using System;
using UnityEngine;

public class TriggeredEnabler : MonoBehaviour
{
    [SerializeField] private TriggerChannel enableChannel;

    private void Awake()
    {
        enableChannel.OnTriggered += Enable;
    }

    private void Start()
    {
        gameObject.SetActive(false);
    }

    private void OnDestroy()
    {
        enableChannel.OnTriggered -= Enable;
    }

    private void Enable()
    {
        gameObject.SetActive(true);
    }
}