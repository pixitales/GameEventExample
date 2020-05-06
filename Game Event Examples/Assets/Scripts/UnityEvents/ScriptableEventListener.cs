using UnityEngine;
using UnityEngine.Events;

public abstract class ScriptableEventListener<T> : MonoBehaviour
{
    protected abstract ScriptableEvent<T> Event { get; }
    protected abstract UnityEvent<T> Response { get; }

    private void OnEnable()
    {
        Event.RegisterListener(this);
    }

    private void OnDisable()
    {
        Event.UnregisterListener(this);
    }

    public void OnEventRaised(T parameter)
    {
        Response?.Invoke(parameter);
    }
}
