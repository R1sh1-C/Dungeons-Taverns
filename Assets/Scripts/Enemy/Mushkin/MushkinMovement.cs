using UnityEngine;

public class MushkinMovement : CharacterMovement
{
    private Enemy enemy;
    private void Awake()
    {
        base.Awake();
        enemy = GetComponent<Enemy>();
    }

    public void Move(Vector2 direction)
    {
        enemy.Rb.MovePosition(enemy.Rb.position + direction * enemy.MovementSpeed * Time.fixedDeltaTime);
    }
}
