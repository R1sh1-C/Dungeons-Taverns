using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Enemy enemy;
    private void Awake()
    {
        enemy = GetComponent<Enemy>();
    }

    public void Move(Vector2 direction)
    {
        enemy.Rb.MovePosition(enemy.Rb.position + direction * enemy.MovementSpeed * Time.fixedDeltaTime);
    }
}
