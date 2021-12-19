using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu]
public class TriggerChannel : ScriptableObject
{
    public event Action OnTriggered;

    public void Trigger()
    {
        OnTriggered?.Invoke();
    }
}