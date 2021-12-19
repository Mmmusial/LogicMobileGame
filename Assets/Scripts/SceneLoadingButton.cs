using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class SceneLoadingButton : MonoBehaviour
{
    [SerializeField] private string levelName;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(LoadLevel);
    }

    private void LoadLevel()
    {
        SceneManager.LoadScene(levelName);
    }
}