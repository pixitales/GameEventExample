using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BoolListener : ScriptableEventListener<bool>
{
    [SerializeField]
    protected BoolEvent eventObject;

    private UnityEventBool eventAction = new UnityEventBool();

    [SerializeField]
    private UnityEvent onTrue;

    [SerializeField]
    private UnityEvent onFalse;

    private void Awake()
    {
        eventAction.AddListener((_state) =>
        {
            if (_state == true)
            {
                onTrue.Invoke();
            }
            else
                onFalse.Invoke();
        });
    }

    protected override ScriptableEvent<bool> Event
    {
        get
        {
            return eventObject;
        }
    }

    protected override UnityEvent<bool> Response
    {
        get
        {
            return eventAction;
        }
    }
}
