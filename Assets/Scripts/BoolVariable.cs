using System;
using UnityEngine;

[CreateAssetMenu]
public class BoolVariable : ScriptableObject
{
    public event Action<bool> OnChanged;

    private bool _value;
        
    public bool Value
    {
        get => _value;
        set
        {
            _value = value;
            OnChanged?.Invoke(value);
        }
    }
}