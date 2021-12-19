using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelReset : MonoBehaviour
{
    [SerializeField] private TriggerChannel resetChannel;

    private void Start()
    {
        resetChannel.OnTriggered += Reset;
    }

    private void OnDestroy()
    {
        resetChannel.OnTriggered -= Reset;
    }

    private void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}