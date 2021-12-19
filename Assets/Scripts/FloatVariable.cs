using System;
using UnityEngine;

[CreateAssetMenu]
public class FloatVariable : ScriptableObject
{
    public event Action<float> OnChanged;

    private float _value;
        
    public float Value
    {
        get => _value;
        set
        {
            _value = value;
            OnChanged?.Invoke(value);
        }
    }
}