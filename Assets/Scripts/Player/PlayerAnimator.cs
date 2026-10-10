using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator animator;
    private PlayerMovement movement;
    private PlayerAttack attack;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        movement = GetComponent<PlayerMovement>();
        attack = GetComponent<PlayerAttack>();
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
    public void PlayAttack()
    {
        animator.SetTrigger("Attack");
    }
}