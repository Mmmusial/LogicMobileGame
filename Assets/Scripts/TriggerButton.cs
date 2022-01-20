using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class TriggerButton : MonoBehaviour
{
    [SerializeField] private TriggerChannel channel;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(Trigger);
    }

    private void Trigger()
    {
        channel.Trigger();
    }
}