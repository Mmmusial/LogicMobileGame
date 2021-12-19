using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class RedGreenLightPresenter : MonoBehaviour
{
    [SerializeField] private BoolVariable redLightOn;

    private Image _icon;

    private void Awake()
    {
        _icon = GetComponent<Image>();
    }

    private void Start()
    {
        redLightOn.OnChanged += Toggle;
    }
        
    private void OnDestroy()
    {
        redLightOn.OnChanged -= Toggle;
    }

    private void Toggle(bool redState)
    {
        _icon.color = redState ? Color.red : Color.green;
    }
}