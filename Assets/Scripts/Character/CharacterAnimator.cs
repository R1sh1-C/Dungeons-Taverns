using UnityEngine;

public class CharacterAnimator : MonoBehaviour
{
    protected Animator animator;
    protected CharacterMovement movement;
    protected void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        animator.SetFloat("xMovement", movement.MoveDirection.x);
        animator.SetFloat("yMovement", movement.MoveDirection.y);
        animator.SetFloat(
            "movementMagnitude",
            movement.MoveDirection.magnitude
        );

        animator.SetFloat("xFace", movement.FaceDirection.x);
        animator.SetFloat("yFace", movement.FaceDirection.y);
    }
}
