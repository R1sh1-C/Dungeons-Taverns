using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    protected Vector2 moveDirection;
    protected Vector2 faceDirection;
    public Vector2 MoveDirection => moveDirection;
    public Vector2 FaceDirection => faceDirection;

    public void SetMovement(Vector2 movement)
    {
        moveDirection = movement.normalized;

        if (moveDirection != Vector2.zero)
        {
            faceDirection = moveDirection;
        }
    }
}
