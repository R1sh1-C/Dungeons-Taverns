using UnityEngine;

public class PlayerMovement : CharacterMovement
{
    private PlayerAttack attack;

    [SerializeField] private float attackingMoveSpeedModifier;

    private void Awake()
    {
        base.Awake();
        attack = GetComponent<PlayerAttack>();
    }

    private void FixedUpdate()
    {
        float currentSpeed = character.MovementSpeed;
        if (attack.IsAttacking)
        {
            currentSpeed *= attackingMoveSpeedModifier;
        }
        character.Rb.MovePosition(
            character.Rb.position +
            moveDirection * currentSpeed * Time.fixedDeltaTime
        );
    }
}