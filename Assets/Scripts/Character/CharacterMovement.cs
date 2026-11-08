using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    protected Character character;
    protected Vector2 moveDirection;
    protected Vector2 faceDirection;
    public Vector2 MoveDirection => moveDirection;
    public Vector2 FaceDirection => faceDirection;
    public void Awake()
    {
        character = GetComponent<Character>();
    }

    public void SetMovement(Vector2 movement)
    {
        moveDirection = movement.normalized;

        if (moveDirection != Vector2.zero)
        {
            faceDirection = moveDirection;
        }
    }
    public void ApplyKnockback(Vector2 hitDirection, float knockbackStrength)
    {
        Debug.Log($"Character: {character}");
        Debug.Log($"Rigidbody: {character?.Rb}");
        Debug.Log($"Movement GameObject: {gameObject.name}");
        character.Rb.MovePosition(
            character.Rb.position +
            hitDirection * knockbackStrength
        );
    }
}
