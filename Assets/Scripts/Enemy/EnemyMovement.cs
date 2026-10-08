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
        transform.position += (Vector3)(enemy.MovementSpeed * direction * Time.deltaTime);
    }
}
