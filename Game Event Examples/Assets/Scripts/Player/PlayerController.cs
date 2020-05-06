using UnityEngine;

[RequireComponent(typeof(PlayerInputActions))]
[RequireComponent(typeof(Rigidbody2D))]

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 3f;

    public PlayerInputActions inputActions { get; set; }
    public Rigidbody2D MyRigidbody { get; private set; }
    public Vector2 Direction { get; private set; }
    public float horizontalInput { get; private set; }
    public float verticalInput { get; private set; }

    public bool IsMoving
    {
        get
        {
            return Direction != Vector2.zero;
        }
    }

    private void Awake()
    {
        inputActions = new PlayerInputActions();

        MyRigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnEnable() => inputActions.Enable();

    private void OnDisable() => inputActions.Disable();

    private void Update()
    {
        SetInputs();
    }

    private void FixedUpdate()
    {
        Vector2 velocity = new Vector2(horizontalInput, verticalInput).normalized;

        Move(velocity);
    }

    private void SetInputs()
    {
        Vector2 moveInput = inputActions.TopdownControls.Movement.ReadValue<Vector2>();

        horizontalInput = moveInput.x;
        verticalInput = moveInput.y;
    }

    private void Move(Vector2 currentVelocity)
    {
        Direction = currentVelocity;
        MyRigidbody.MovePosition(MyRigidbody.position + currentVelocity * moveSpeed * Time.deltaTime);
    }
}
