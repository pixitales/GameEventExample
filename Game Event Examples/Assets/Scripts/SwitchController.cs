using UnityEngine;

public enum SwitchType { openDoor, closeDoor }

public class SwitchController : MonoBehaviour
{
    [SerializeField] private SwitchType switchType;
    [SerializeField] private BoolEvent onPressed;
    [SerializeField] private StringEvent hello;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            switch (switchType)
            {
                case SwitchType.openDoor:
                    onPressed.Invoke(true);
                    hello.Invoke("Open Door");
                    break;

                case SwitchType.closeDoor:
                    onPressed.Invoke(false);
                    hello.Invoke("Close Door");
                    break;
            }
        }
    }
}
