using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private PlayerController Player;
    [SerializeField] private Animator MyAnimator;

    private readonly int HashHorizontalSpeed = Animator.StringToHash("HorizontalSpeed");
    private readonly int HashVerticalSpeed = Animator.StringToHash("VerticalSpeed");
    private readonly int MoveSpeed = Animator.StringToHash("MoveSpeed");
    private readonly int Moving = Animator.StringToHash("Moving");

    private Vector2 Lastmove;

    private void Update()
    {
        if (Player.Direction != Vector2.zero)
        {
            MyAnimator.SetFloat(HashHorizontalSpeed, Player.horizontalInput);
            MyAnimator.SetFloat(HashVerticalSpeed, Player.verticalInput);
            Lastmove = new Vector2(Player.Direction.x, Player.Direction.y);
        }

        MyAnimator.SetFloat(HashHorizontalSpeed, Lastmove.x);
        MyAnimator.SetFloat(HashVerticalSpeed, Lastmove.y);

        MyAnimator.SetBool(Moving, Player.IsMoving);
    }
}