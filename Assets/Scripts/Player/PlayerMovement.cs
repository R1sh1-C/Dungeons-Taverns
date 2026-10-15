using UnityEngine;

public class PlayerMovement : CharacterMovement
{
    private Rigidbody2D rb;
    private Character character;
    private PlayerAttack attack;

    [SerializeField] private float attackingMoveSpeedModifier;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        character = GetComponent<Character>();
        attack = GetComponent<PlayerAttack>();
    }

    private void FixedUpdate()
    {
        float currentSpeed = character.MovementSpeed;
        if (attack.IsAttacking)
        {
            currentSpeed *= attackingMoveSpeedModifier;
        }
        rb.MovePosition(
            rb.position +
            moveDirection * currentSpeed * Time.fixedDeltaTime
        );
        Debug.Log(currentSpeed);
    }
}