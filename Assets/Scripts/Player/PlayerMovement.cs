using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Character character;
    private PlayerAttack attack;

    private Vector2 moveDirection;
    private Vector2 faceDirection;

    [SerializeField] private float attackingMoveSpeedModifier;
    public Vector2 MoveDirection => moveDirection;
    public Vector2 FaceDirection => faceDirection;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        character = GetComponent<Character>();
        attack = GetComponent<PlayerAttack>();
    }

    private void FixedUpdate()
    {
        float currentSpeed = character.MovementSpeed;
        Debug.Log(attack.IsAttacking);
        if (attack.IsAttacking)
        {
            currentSpeed *= attackingMoveSpeedModifier;
        }
        rb.MovePosition(
            rb.position +
            moveDirection * currentSpeed * Time.fixedDeltaTime
        );
    }

    public void SetMovement(Vector2 movement)
    {
        moveDirection = movement.normalized;

        if (moveDirection != Vector2.zero)
        {
            faceDirection = moveDirection;
        }
    }
}