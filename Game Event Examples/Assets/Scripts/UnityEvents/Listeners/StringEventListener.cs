using UnityEngine;
using UnityEngine.Events;

public class StringEventListener : ScriptableEventListener<string>
{
    [SerializeField]
    protected StringEvent eventObject;

    [SerializeField]
    protected UnityEventString eventAction;

    protected override ScriptableEvent<string> Event
    {
        get
        {
            return eventObject;
        }
    }

    protected override UnityEvent<string> Response
    {
        get
        {
            return eventAction;
        }
    }
}
