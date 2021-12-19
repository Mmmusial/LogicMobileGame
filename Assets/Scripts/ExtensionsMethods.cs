using UnityEngine;

public static class ExtensionsMethods
{
    public static bool IsPlayer(this Component other)
    {
        return other.CompareTag("Player");
    }
}