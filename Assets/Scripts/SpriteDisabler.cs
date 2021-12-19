using System;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteDisabler : MonoBehaviour
{
    private void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }
}