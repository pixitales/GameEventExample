using UnityEngine;
using UnityEngine.Events;

public class FloatEventListener : ScriptableEventListener<float>
{
    [SerializeField]
    protected FloatEvent eventObject;

    [SerializeField]
    protected UnityEventFloat eventAction;

    protected override ScriptableEvent<float> Event
    {
        get { return eventObject; }
    }

    protected override UnityEvent<float> Response
    {
        get { return eventAction; }
    }
}
