using UnityEngine;

public class MultipleTriggerNotifier : MonoBehaviour
{
    [SerializeField] private int requiredTriggerCount;
    [SerializeField] private TriggerChannel channel;

    private int _triggerCount;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.IsPlayer())
        {
            return;
        }

        if (++_triggerCount >= requiredTriggerCount)
        {
            channel.Trigger();
        }
    }
}