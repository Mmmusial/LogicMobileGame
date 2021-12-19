using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TriggerStayNotifier : MonoBehaviour
{
    [SerializeField] private TriggerChannel channel;
    [SerializeField] private float delay;

    private float _secondsElapsed;
    private bool _isInside;

    private void Update()
    {
        if (_isInside)
        {
            _secondsElapsed += Time.deltaTime;
        }

        if (_secondsElapsed >= delay)
        {
            channel.Trigger();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.IsPlayer())
        {
            _isInside = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (!other.IsPlayer())
        {
            return;
        }
        
        _secondsElapsed = 0f;
        _isInside = false;
    }
}
