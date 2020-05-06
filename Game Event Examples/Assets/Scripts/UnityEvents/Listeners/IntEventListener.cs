using UnityEngine;
using UnityEngine.Events;

public class IntEventListener : ScriptableEventListener<int>
{
    [SerializeField]
    protected IntEvent eventObject;

    [SerializeField]
    protected UnityEventInt eventAction;

    protected override ScriptableEvent<int> Event
    {
        get
        {
            return eventObject;
        }
    }

    protected override UnityEvent<int> Response
    {
        get
        {
            return eventAction;
        }
    }
}
